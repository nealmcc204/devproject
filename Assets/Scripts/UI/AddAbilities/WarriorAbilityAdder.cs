using UnityEngine;
using System.Collections;

public class WarriorAbilityAdder : MonoBehaviour {

	public WarriorPlayer wp;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void AddDamageTest()
	{
		wp.AddOffensiveAbility (new DamageTest ());
	}
		
}