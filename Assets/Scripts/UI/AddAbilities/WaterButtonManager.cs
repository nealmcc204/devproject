using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WaterButtonManager : MonoBehaviour {

	// Use this for initialization
	public SceneNavigator sceneNavigator;

	public List<Button> buttons = new List<Button>();
	private MagePlayer mp;

	void Start () {
		mp = (MagePlayer)FindObjectOfType<MagePlayer> ();
		foreach (Button b in buttons)
			b.interactable = false;

		buttons [0].interactable = true;
		buttons [1].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddSingleWaterS()
	{
		mp.AddOffensiveAbility (new SingleWaterS ());
		Advance ();
	}

	public void AddSingleWaterM()
	{
		mp.RemoveOffensiveAbility (new SingleWaterS());
		mp.AddOffensiveAbility (new SingleWaterM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [3].interactable = true;
		buttons [4].interactable = true;
		Advance ();
	}

	public void AddSingleWaterL()
	{
		mp.RemoveOffensiveAbility (new SingleWaterM ());
		mp.AddOffensiveAbility (new SingleWaterL ());
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [7].interactable = true;
		buttons [8].interactable = true;
		Advance ();
	}

	public void AddSingleWaterH()
	{
		mp.RemoveOffensiveAbility (new SingleWaterL());
		mp.AddOffensiveAbility (new SingleWaterH ());
		foreach (Button b in buttons)
			b.interactable = false;
		Advance ();
	}

	public void AddDoubleWaterS()
	{
		mp.RemoveOffensiveAbility (new SingleWaterS ());
		mp.AddOffensiveAbility (new DoubleWaterS ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [2].interactable = true;
		buttons [3].interactable = true;
		Advance ();
	}

	public void AddDoubleWaterM()
	{
		mp.RemoveOffensiveAbility (new DoubleWaterS ());
		mp.RemoveOffensiveAbility (new SingleWaterM ());
		mp.AddOffensiveAbility (new DoubleWaterM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;
		buttons [2].interactable = false;
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [6].interactable = true;
		buttons [7].interactable = true;
		Advance ();
	}

	public void AddDoubleWaterL()
	{
		mp.RemoveOffensiveAbility (new DoubleWaterM ());
		mp.RemoveOffensiveAbility (new SingleWaterL ());
		mp.AddOffensiveAbility (new DoubleWaterL ());
		foreach (Button b in buttons)
			b.interactable = false;
		Advance ();
	}

	public void AddTripleWaterS()
	{
		mp.RemoveOffensiveAbility (new DoubleWaterS ());
		mp.AddOffensiveAbility (new TripleWaterS ());
		buttons [0].interactable = false;
		buttons [3].interactable = false;

		buttons [5].interactable = true;
		buttons [6].interactable = true;
		Advance ();
	}

	public void AddTripleWaterM()
	{
		mp.RemoveOffensiveAbility (new TripleWaterS ());
		mp.RemoveOffensiveAbility (new DoubleWaterM ());
		mp.AddOffensiveAbility (new TripleWaterM ());
		foreach (Button b in buttons)
			b.interactable = false;
		Advance ();
	}

	public void AddAllWaterS()
	{
		mp.RemoveOffensiveAbility (new TripleWaterS ());
		mp.AddOffensiveAbility (new AllWaterS ());
		foreach (Button b in buttons)
			b.interactable = false;
		Advance ();
	}

	public void Advance()
	{
		sceneNavigator.GoToMageEarthAbilities ();
	}
}
