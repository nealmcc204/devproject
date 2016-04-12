using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class EarthButtonManager : MonoBehaviour {

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

	public void AddSingleEarthS()
	{
		mp.AddOffensiveAbility (new SingleEarthS ());
		Advance ();
	}

	public void AddSingleEarthM()
	{
		mp.RemoveOffensiveAbility (new SingleEarthS());
		mp.AddOffensiveAbility (new SingleEarthM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [3].interactable = true;
		buttons [4].interactable = true;
		Advance ();
	}

	public void AddSingleEarthL()
	{
		mp.RemoveOffensiveAbility (new SingleEarthM ());
		mp.AddOffensiveAbility (new SingleEarthL ());
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [7].interactable = true;
		buttons [8].interactable = true;
		Advance ();
	}

	public void AddSingleEarthH()
	{
		mp.RemoveOffensiveAbility (new SingleEarthL());
		mp.AddOffensiveAbility (new SingleEarthH ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddDoubleEarthS()
	{
		mp.RemoveOffensiveAbility (new SingleEarthS ());
		mp.AddOffensiveAbility (new DoubleEarthS ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [2].interactable = true;
		buttons [3].interactable = true;
		Advance ();
	}

	public void AddDoubleEarthM()
	{
		mp.RemoveOffensiveAbility (new DoubleEarthS ());
		mp.RemoveOffensiveAbility (new SingleEarthM ());
		mp.AddOffensiveAbility (new DoubleEarthM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;
		buttons [2].interactable = false;
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [6].interactable = true;
		buttons [7].interactable = true;
		Advance ();
	}

	public void AddDoubleEarthL()
	{
		mp.RemoveOffensiveAbility (new DoubleEarthM ());
		mp.RemoveOffensiveAbility (new SingleEarthL ());
		mp.AddOffensiveAbility (new DoubleEarthL ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddTripleEarthS()
	{
		mp.RemoveOffensiveAbility (new DoubleEarthS ());
		mp.AddOffensiveAbility (new TripleEarthS ());
		buttons [0].interactable = false;
		buttons [3].interactable = false;

		buttons [5].interactable = true;
		buttons [6].interactable = true;
		Advance ();
	}

	public void AddTripleEarthM()
	{
		mp.RemoveOffensiveAbility (new TripleEarthS ());
		mp.RemoveOffensiveAbility (new DoubleEarthM ());
		mp.AddOffensiveAbility (new TripleEarthM ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddAllEarthS()
	{
		mp.RemoveOffensiveAbility (new TripleEarthS ());
		mp.AddOffensiveAbility (new AllEarthS ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void Advance()
	{
		sceneNavigator.GoToMageHealingAbilities ();
	}
}
