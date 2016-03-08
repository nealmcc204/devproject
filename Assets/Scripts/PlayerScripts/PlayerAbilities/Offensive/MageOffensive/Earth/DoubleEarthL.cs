using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleEarthL : BaseEarth {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		foreach (Enemy e in targets) {
			success = e.ReduceHealth (LargeDamage(), e.GetShield(), AttackElement() );
			if (success) {
				e.SetStatus (Status.DAZED);
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
		string ad = "Deals" + LargeDamage() + "of earth damage to two enemies, and dazes them. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}