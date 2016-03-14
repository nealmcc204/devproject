using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class HealingButtonManager : MonoBehaviour {

	// Use this for initialization
	public static HealingButtonManager hbm;
	public SceneNavigator sceneNavigator;

	public List<Button> buttons = new List<Button>();
	public MagePlayer mp;

	void Awake() {//Mage Player Singleton
		if (!hbm) {
			hbm = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}

	void Start () {
		foreach (Button b in buttons)
			b.interactable = false;

		buttons [0].interactable = true;
		buttons [1].interactable = true;
		buttons [5].interactable = true;
		buttons [8].interactable = true;
		buttons [10].interactable = true;
		buttons [12].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddSingleHealS()
	{
		mp.AddDefensiveAbility (new SingleHealS ());
		Advance ();
	}

	public void AddSingleHealM()
	{
		mp.RemoveDefensiveAbility (new SingleHealS());
		mp.AddDefensiveAbility (new SingleHealM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [2].interactable = true;
		buttons [3].interactable = true;
		Advance ();
	}

	public void AddSingleHealFull()
	{
		mp.RemoveDefensiveAbility (new SingleHealM ());
		mp.AddDefensiveAbility (new SingleHealFull ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;
		buttons [2].interactable = false;
		buttons [3].interactable = false;
		Advance ();
	}

	public void AddDoubleHealS()
	{
		mp.RemoveDefensiveAbility (new SingleHealS ());
		mp.AddDefensiveAbility (new DoubleHealS ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [2].interactable = true;
		buttons [3].interactable = true;
		Advance ();
	}

	public void AddDoubleHealM()
	{
		mp.RemoveDefensiveAbility (new DoubleHealS ());
		mp.RemoveDefensiveAbility (new SingleHealM ());
		mp.AddDefensiveAbility (new DoubleHealM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;
		buttons [2].interactable = false;
		buttons [3].interactable = false;
		Advance ();
	}

	public void AddDoubleHealFull()
	{
		mp.RemoveDefensiveAbility (new DoubleHealM ());
		mp.RemoveDefensiveAbility (new SingleHealFull ());
		mp.AddDefensiveAbility (new DoubleHealFull ());
		buttons [4].interactable = false;
		Advance ();
	}

	public void AddLesserRevive()
	{
		mp.AddDefensiveAbility (new LesserRevive ());
		buttons [5].interactable = false;
		buttons [6].interactable = true;
		Advance ();
	}

	public void AddRevive()
	{
		mp.RemoveDefensiveAbility (new LesserRevive ());
		mp.AddDefensiveAbility (new Revive ());
		buttons [6].interactable = false;
		buttons [7].interactable = true;
		Advance ();
	}

	public void AddGreaterRevive()
	{
		mp.RemoveDefensiveAbility (new Revive ());
		mp.AddDefensiveAbility (new GreaterRevive ());
		buttons [7].interactable = false;
		Advance ();
	}

	public void AddSingleWaterShield()
	{
		mp.AddDefensiveAbility (new SingleWaterShield ());
		buttons [8].interactable = false;
		buttons [9].interactable = true;
		Advance ();
	}

	public void AddDoubleWaterShield()
	{
		mp.RemoveDefensiveAbility (new SingleWaterShield ());
		mp.AddDefensiveAbility (new DoubleWaterShield ());
		buttons [9].interactable = false;
		Advance ();
	}

	public void AddSingleFireShield()
	{
		mp.AddDefensiveAbility (new SingleFireShield ());
		buttons [10].interactable = false;
		buttons [11].interactable = true;
		Advance ();
	}

	public void AddDoubleFireShield()
	{
		mp.RemoveDefensiveAbility (new SingleFireShield ());
		mp.AddDefensiveAbility (new DoubleFireShield ());
		buttons [11].interactable = false;
		Advance ();
	}

	public void AddSingleEarthShield()
	{
		mp.AddDefensiveAbility (new SingleEarthShield ());
		buttons [12].interactable = false;
		buttons [13].interactable = true;
		Advance ();
	}

	public void AddDoubleEarthShield()
	{
		mp.RemoveDefensiveAbility (new SingleEarthShield ());
		mp.AddDefensiveAbility (new DoubleEarthShield ());
		buttons [13].interactable = false;
		Advance ();
	}

	public void Advance()
	{
		sceneNavigator.GoToWarriorOffensiveAbilities ();
	}

}