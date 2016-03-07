using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TripleEarthM : BaseEarth {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 3; i++) {
			success = targets [i].ReduceHealth (MediumDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.DAZED);
			}		
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "TripleEarthM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + MediumDamage() + "of earth damage to three enemies, and dazes them. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}