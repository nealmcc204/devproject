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

	public void AddSingleFireM()
	{
		mp.AddOffensiveAbility (new SingleFireM ());
	}

	public void AddSingleFireL()
	{
		mp.AddOffensiveAbility (new SingleFireL ());
	}

	public void AddSingleFireH()
	{
		mp.AddOffensiveAbility (new SingleFireH ());
	}

	public void AddDoubleFireS()
	{
		mp.AddOffensiveAbility (new DoubleFireS ());
	}

	public void AddDoubleFireM()
	{
		mp.AddOffensiveAbility (new DoubleFireM ());
	}

	public void AddDoubleFireL()
	{
		mp.AddOffensiveAbility (new DoubleFireL ());
	}

	public void AddTripleFireS()
	{
		mp.AddOffensiveAbility (new TripleFireS ());
	}

	public void AddTripleFireM()
	{
		mp.AddOffensiveAbility (new TripleFireM ());
	}

	public void AddAllFireS()
	{
		mp.AddOffensiveAbility (new AllFireS ());
	}
		
	public void AddSingleWaterS()
	{
		mp.AddOffensiveAbility (new SingleWaterS ());
	}

	public void AddSingleWaterM()
	{
		mp.AddOffensiveAbility (new SingleWaterM ());
	}

	public void AddSingleWaterL()
	{
		mp.AddOffensiveAbility (new SingleWaterL ());
	}

	public void AddSingleWaterH()
	{
		mp.AddOffensiveAbility (new SingleWaterH ());
	}

	public void AddDoubleWaterS()
	{
		mp.AddOffensiveAbility (new DoubleWaterS ());
	}

	public void AddDoubleWaterM()
	{
		mp.AddOffensiveAbility (new DoubleWaterM ());
	}

	public void AddDoubleWaterL()
	{
		mp.AddOffensiveAbility (new DoubleWaterL ());
	}

	public void AddTripleWaterS()
	{
		mp.AddOffensiveAbility (new TripleWaterS ());
	}

	public void AddTripleWaterM()
	{
		mp.AddOffensiveAbility (new TripleWaterM ());
	}

	public void AddAllWaterS()
	{
		mp.AddOffensiveAbility (new AllWaterS ());
	}

	//Defensive

	public void AddSingleHealS()
	{
		mp.AddDefensiveAbility (new SingleHealS ());
	}

	public void AddSingleHealM()
	{
		mp.AddDefensiveAbility (new SingleHealM ());
	}

	public void AddSingleHealFull()
	{
		mp.AddDefensiveAbility (new SingleHealFull ());
	}

	public void AddDoubleHealS()
	{
		mp.AddDefensiveAbility (new DoubleHealS ());
	}

	public void AddDoubleHealM()
	{
		mp.AddDefensiveAbility (new DoubleHealM ());
	}

	public void AddDoubleHealFull()
	{
		mp.AddDefensiveAbility (new DoubleHealFull ());
	}

	public void AddLesserRevive()
	{
		mp.AddDefensiveAbility (new LesserRevive ());
	}

	public void AddRevive()
	{
		mp.AddDefensiveAbility (new Revive ());
	}

	public void AddGreaterRevive()
	{
		mp.AddDefensiveAbility (new GreaterRevive ());
	}

	public void AddSingleFireShield()
	{
		mp.AddDefensiveAbility (new SingleFireShield());
	}

	public void AddDoubleFireShield()
	{
		mp.AddDefensiveAbility (new DoubleFireShield());
	}

	public void AddSingleEarthShield()
	{
		mp.AddDefensiveAbility (new SingleEarthShield());
	}

	public void AddDoubleEarthSheild()
	{
		mp.AddDefensiveAbility (new DoubleEarthShield());
	}

	public void AddSingleWaterShield()
	{
		mp.AddDefensiveAbility (new SingleWaterShield());
	}

	public void AddDoubleWaterShield()
	{
		mp.AddDefensiveAbility (new DoubleWaterShield());
	}
}
