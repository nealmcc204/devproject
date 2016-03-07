using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleEarthL : BaseEarth {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 2; i++) {
			success = targets [i].ReduceHealth (LargeDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.DAZED);
			}
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "DoubleEarthL";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + LargeDamage() + "of earth damage to two enemies, and burns them. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}