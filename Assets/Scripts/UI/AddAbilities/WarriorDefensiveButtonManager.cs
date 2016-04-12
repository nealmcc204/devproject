using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WarriorDefensiveButtonManager : MonoBehaviour {

	// Use this for initialization
	public SceneNavigator sceneNavigator;

	public List<Button> buttons = new List<Button>();
	private WarriorPlayer wp;

	void Start () {
		wp = (WarriorPlayer)FindObjectOfType<WarriorPlayer> ();
		foreach (Button b in buttons)
			b.interactable = false;

		buttons [0].interactable = true;
		buttons [3].interactable = true;
		buttons [4].interactable = true;
		buttons [5].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddTauntS()
	{
		wp.AddDefensiveAbility (new TauntS ());
		buttons [0].interactable = false;
		buttons [1].interactable = true;
		Advance ();
	}

	public void AddTauntM()
	{
		wp.RemoveDefensiveAbility (new TauntS());
		wp.AddDefensiveAbility (new TauntM());
		buttons [1].interactable = false;
		buttons [2].interactable = true;
		Advance ();
	}

	public void AddTauntL()
	{
		wp.RemoveDefensiveAbility (new TauntM());
		wp.AddDefensiveAbility (new TauntL());
		buttons [2].interactable = false;
		Advance ();
	}

	public void AddWeakRevive()
	{
		wp.AddDefensiveAbility (new WeakRevive ());
		buttons [3].interactable = false;
		Advance ();
	}

	public void AddWeakHeal()
	{
		wp.AddDefensiveAbility (new WeakHeal ());
		buttons [4].interactable = false;
		Advance ();
	}
		
	public void AddWithstand()
	{
		wp.AddDefensiveAbility (new Withstand());
		buttons [5].interactable = false;
		Advance ();
	}

	public void Advance()
	{
		sceneNavigator.GoToPreScreen ();
	}

}