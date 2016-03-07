using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleFireS : BaseFire {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 2; i++) {
			success = targets [i].ReduceHealth (SmallDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.BURNED);
			}
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "DoubleFireS";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of fire damage to two enemies, and burns them. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}