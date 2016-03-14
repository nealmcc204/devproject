using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FireButtonManager : MonoBehaviour {

	// Use this for initialization
	public static FireButtonManager fbm;
	public SceneNavigator sceneNavigator;
	public GameObject magePrefab;
	private GameObject character;

	public List<Button> buttons = new List<Button>();
	private MagePlayer mp;

	void Awake() {//Mage Player Singleton
		if (!fbm) {
			fbm = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}

	void Start () {
		character = (GameObject)Instantiate (magePrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		mp = character.GetComponentInChildren<MagePlayer> ();
		foreach (Button b in buttons)
			b.interactable = false;

		buttons [0].interactable = true;
		buttons [1].interactable = true;
	}

	// Update is called once per frame
	void Update () {

	}

	public void AddSingleFireS()
	{
		mp.AddOffensiveAbility (new SingleFireS ());
		Advance ();
	}

	public void AddSingleFireM()
	{
		mp.RemoveOffensiveAbility (new SingleFireS());
		mp.AddOffensiveAbility (new SingleFireM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [3].interactable = true;
		buttons [4].interactable = true;
		Advance ();
	}

	public void AddSingleFireL()
	{
		mp.RemoveOffensiveAbility (new SingleFireM ());
		mp.AddOffensiveAbility (new SingleFireL ());
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [7].interactable = true;
		buttons [8].interactable = true;
		Advance ();
	}

	public void AddSingleFireH()
	{
		mp.RemoveOffensiveAbility (new SingleFireL());
		mp.AddOffensiveAbility (new SingleFireH ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddDoubleFireS()
	{
		mp.RemoveOffensiveAbility (new SingleFireS ());
		mp.AddOffensiveAbility (new DoubleFireS ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;

		buttons [2].interactable = true;
		buttons [3].interactable = true;
		Advance ();
	}

	public void AddDoubleFireM()
	{
		mp.RemoveOffensiveAbility (new DoubleFireS ());
		mp.RemoveOffensiveAbility (new SingleFireM ());
		mp.AddOffensiveAbility (new DoubleFireM ());
		buttons [0].interactable = false;
		buttons [1].interactable = false;
		buttons [2].interactable = false;
		buttons [3].interactable = false;
		buttons [4].interactable = false;

		buttons [6].interactable = true;
		buttons [7].interactable = true;
		Advance ();
	}

	public void AddDoubleFireL()
	{
		mp.RemoveOffensiveAbility (new DoubleFireM ());
		mp.RemoveOffensiveAbility (new SingleFireL ());
		mp.AddOffensiveAbility (new DoubleFireL ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddTripleFireS()
	{
		mp.RemoveOffensiveAbility (new DoubleFireS ());
		mp.AddOffensiveAbility (new TripleFireS ());
		buttons [0].interactable = false;
		buttons [3].interactable = false;

		buttons [5].interactable = true;
		buttons [6].interactable = true;
		Advance ();
	}

	public void AddTripleFireM()
	{
		mp.RemoveOffensiveAbility (new TripleFireS ());
		mp.RemoveOffensiveAbility (new DoubleFireM ());
		mp.AddOffensiveAbility (new TripleFireM ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void AddAllFireS()
	{
		mp.RemoveOffensiveAbility (new TripleFireS ());
		mp.AddOffensiveAbility (new AllFireS ());
		foreach (Button b in buttons)
			b.interactable = false;

		Advance ();
	}

	public void Advance()
	{
		SceneManager.LoadScene ("CombatScene");
		//sceneNavigator.GoToMageWaterAbilities();
	}
}
