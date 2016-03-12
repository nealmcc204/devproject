using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WarriorOffensiveButtonManager : MonoBehaviour {

	// Use this for initialization
	public static WarriorOffensiveButtonManager wobm;

	public List<Button> buttons = new List<Button>();
	public WarriorPlayer mp;

	void Awake() {//Mage Player Singleton
		if (!wobm) {
			wobm = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}

	void Start () {
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
		mp.RemoveOffensiveAbility (new DoubleStrikeS());
		mp.AddOffensiveAbility (new DoubleStrikeM ());
		buttons [0].interactable = false;
		buttons [1].interactable = true;
	}

	public void AddDoubleStrikeL()
	{
		mp.RemoveOffensiveAbility (new DoubleStrikeM());
		mp.AddOffensiveAbility (new DoubleStrikeL());
		buttons [1].interactable = false;
		buttons [2].interactable = true;
	}

	public void AddTripleStrikeL()
	{
		mp.RemoveOffensiveAbility (new DoubleStrikeL());
		mp.AddOffensiveAbility (new TripleStrikeL());
		buttons [2].interactable = false;
	}

	public void AddStunSmashM()
	{
		mp.RemoveOffensiveAbility (new StunSmashS());
		mp.AddOffensiveAbility (new StunSmashM ());
		buttons [3].interactable = false;
		buttons [4].interactable = true;
	}

	public void AddStunSmashL()
	{
		mp.RemoveOffensiveAbility (new StunSmashM());
		mp.AddOffensiveAbility (new StunSmashL ());
		buttons [4].interactable = false;
		buttons [5].interactable = true;
	}

	public void AddStunSmashH()
	{
		mp.RemoveOffensiveAbility (new StunSmashL());
		mp.AddOffensiveAbility (new StunSmashH());
		buttons [5].interactable = false;
	}

}