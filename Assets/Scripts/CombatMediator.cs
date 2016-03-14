﻿using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CombatMediator : MonoBehaviour {

	// Use this for initialization
    public PlayerManager playerManager;
    public EnemyManager enemyManager;
	public SceneNavigator sceneNavigator;
	private List<Unit> units;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
       
	}

	private void SortUnitsBySpeed(List<Unit> u)
	{
		for (int i = 0; i < u.Count - 1; i++) {
			for (int j = i + 1; j < u.Count; j++) {
				if (u [i].GetSpeed () < u [j].GetSpeed ()) {
					Unit temp = u [i];
					u [i] = u [j];
					u [j] = temp;
				}
			}
		}
		foreach (Unit un in u) {
			if (un.GetStatus() == Status.FROZEN) {//only frozen for one turn, once speed is calculated for this turn, unfrozen.
				un.SetStatus (Status.NONE);
			}
		}
	}

	public void TestFight()
	{
		foreach (Enemy e in enemyManager.Enemies) {
			e.DoMove (playerManager.Players, enemyManager.Enemies);
		}
		Debug.Log ("Execution Complete.");
		Debug.Log(String.Format("Warrior Player health {0} ", playerManager.Players[0].GetCurrentHealth()));
	}

	public void StartGame()
	{
		units = new List<Unit> ();
		foreach (Player p in playerManager.Players) {
			units.Add (p);
		}
		foreach (Enemy e in enemyManager.Enemies) {
			units.Add (e);
		}

		StartCoroutine(CombatPhase ());
	}

	IEnumerator CombatPhase()
	{
		while (!CombatComplete ()) {
			SortUnitsBySpeed (units);
			foreach (Unit u in units) {
				u.SetTurnComplete (false);
				if (u.GetTaunting ()) {
					u.SetTaunt (false);
				}
				if (!u.GetDead () && u.GetStatus() != Status.STUNNED) {

					u.DoMove (playerManager.Players, enemyManager.Enemies);
					while (!u.GetTurnComplete ()) {
						yield return new WaitForSeconds(0.05f);
					}
				} else {
					u.SetStatus (Status.NONE);
				}
			}
		}
		if (Victory ())
			sceneNavigator.GoToVictoryScreen ();
		else
			sceneNavigator.GoToDefeatScreen ();
		//if victory go to victory / level up screen
		//if defeat try again
	}

	private bool Defeat()
	{
		foreach (Player p in playerManager.Players) {
			if (!p.GetDead ()) {
				return false;
			}
		}
		Debug.Log ("Defeat");
		return true;
	}

	private bool Victory()
	{
		foreach (Enemy e in enemyManager.Enemies) {
			if (!e.GetDead ()) {
				return false;
			}
		}
		Debug.Log ("Victory");
		return true;
	}

	private bool CombatComplete()
	{
		if (Victory () || Defeat ()) {
			return true;
		}
		return false;
	}
}
