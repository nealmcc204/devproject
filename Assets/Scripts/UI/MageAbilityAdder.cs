using UnityEngine;
using System.Collections;

public class MageAbilityAdder : MonoBehaviour {

	public MagePlayer mp;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void AddDamageTest()
	{
		mp.AddOffensiveAbility (new DamageTest ());
	}

	public void AddHealTest()
	{
		mp.AddDefensiveAbility (new HealTest ());
	}

	public void AddShieldTest()
	{
		mp.AddDefensiveAbility (new ShieldTest ());
	}

	public void AddSingleFireS()
	{
		mp.AddOffensiveAbility (new SingleFireS ());
	}
}
