using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;

public class WarriorDefensiveButtonManager : MonoBehaviour {

	// Use this for initialization
	public static WarriorDefensiveButtonManager wdbm;
	public SceneNavigator sceneNavigator;

	public List<Button> buttons = new List<Button>();
	public WarriorPlayer mp;

	void Awake() {//Mage Player Singleton
		if (!wdbm) {
			wdbm = this;
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
		buttons [4].interactable = true;
		buttons [5].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddTauntS()
	{
		mp.AddDefensiveAbility (new TauntS ());
		buttons [0].interactable = false;
		buttons [1].interactable = true;
	}

	public void AddTauntM()
	{
		mp.RemoveDefensiveAbility (new TauntS());
		mp.AddDefensiveAbility (new TauntM());
		buttons [1].interactable = false;
		buttons [2].interactable = true;
	}

	public void AddTauntL()
	{
		mp.RemoveDefensiveAbility (new TauntM());
		mp.AddDefensiveAbility (new TauntL());
		buttons [2].interactable = false;
	}

	public void AddWeakRevive()
	{
		mp.AddDefensiveAbility (new WeakRevive ());
		buttons [3].interactable = false;
	}

	public void AddWeakHeal()
	{
		mp.AddDefensiveAbility (new WeakHeal ());
		buttons [4].interactable = false;
	}
		
	public void AddWithstand()
	{
		mp.AddDefensiveAbility (new Withstand());
		buttons [5].interactable = false;
	}

	public void Advance()
	{
		sceneNavigator.GoToPreScreen ();
	}

}