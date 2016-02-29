using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class CombatMediator : MonoBehaviour {

	// Use this for initialization
    public PlayerManager playerManager;
    public EnemyManager enemyManager;
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
	}

	public void TestFight()
	{
		/*Debug.Log ("Aye");
		int health = playerManager.Players[1].GetMaxHealth ();
		bool success;

		playerManager.Players[0].SetHealth((playerManager.Players[0].GetMaxHealth() - 50));
		health =  playerManager.Players[0].GetCurrentHealth();

		success = playerManager.Players[1].UseAbility(playerManager.Players[1].defensiveAbilities[0], playerManager.Players[0]);
		health = playerManager.Players[0].GetCurrentHealth();
		string abilitytag =playerManager.Players [1].defensiveAbilities [0].GetAbilityTag ();

		success = playerManager.Players [1].UseAbility (playerManager.Players [1].defensiveAbilities [1], playerManager.Players [0]);
		Shield shield = playerManager.Players [0].GetShield ();

		health = enemyManager.Enemies [0].GetCurrentHealth ();
		success = playerManager.Players [0].UseAbility (playerManager.Players [0].offensiveAbilities [0], enemyManager.Enemies [0]);
		health = enemyManager.Enemies [0].GetCurrentHealth ();

		enemyManager.Enemies [0].DoMove (playerManager.Players, enemyManager.Enemies);*/
		units = new List<Unit> ();
		foreach (Player p in playerManager.Players) {
			units.Add (p);
		}
		foreach (Enemy e in enemyManager.Enemies) {
			units.Add (e);
		}
		SortUnitsBySpeed (units);

		foreach (Enemy e in enemyManager.Enemies) {
			e.DoMove (playerManager.Players, enemyManager.Enemies);
		}
		Debug.Log ("Execution Complete.");
		Debug.Log(String.Format("Warrior Player health {0} ", playerManager.Players[0].GetCurrentHealth()));

	}
}
