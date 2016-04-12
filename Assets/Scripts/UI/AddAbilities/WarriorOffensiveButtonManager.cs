using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WarriorOffensiveButtonManager : MonoBehaviour {

	// Use this for initialization
	public SceneNavigator sceneNavigator;

	public List<Button> buttons = new List<Button>();
	public WarriorPlayer wp;

	void Start () {
		wp = (WarriorPlayer)FindObjectOfType<WarriorPlayer> ();
		foreach (Button b in buttons)
			b.interactable = false;

		buttons [0].interactable = true;
		buttons [3].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddDoubleStrikeM()
	{
		wp.RemoveOffensiveAbility (new DoubleStrikeS());
		wp.AddOffensiveAbility (new DoubleStrikeM ());
		buttons [0].interactable = false;
		buttons [1].interactable = true;
		Advance ();
	}

	public void AddDoubleStrikeL()
	{
		wp.RemoveOffensiveAbility (new DoubleStrikeM());
		wp.AddOffensiveAbility (new DoubleStrikeL());
		buttons [1].interactable = false;
		buttons [2].interactable = true;
		Advance ();
	}

	public void AddTripleStrikeL()
	{
		wp.RemoveOffensiveAbility (new DoubleStrikeL());
		wp.AddOffensiveAbility (new TripleStrikeL());
		buttons [2].interactable = false;
		Advance ();
	}

	public void AddStunSmashM()
	{
		wp.RemoveOffensiveAbility (new StunSmashS());
		wp.AddOffensiveAbility (new StunSmashM ());
		buttons [3].interactable = false;
		buttons [4].interactable = true;
		Advance ();
	}

	public void AddStunSmashL()
	{
		wp.RemoveOffensiveAbility (new StunSmashM());
		wp.AddOffensiveAbility (new StunSmashL ());
		buttons [4].interactable = false;
		buttons [5].interactable = true;
		Advance ();
	}

	public void AddStunSmashH()
	{
		wp.RemoveOffensiveAbility (new StunSmashL());
		wp.AddOffensiveAbility (new StunSmashH());
		buttons [5].interactable = false;
		Advance ();
	}

	public void Advance()
	{
		sceneNavigator.GoToWarriorDefensiveAbilities ();
	}

}