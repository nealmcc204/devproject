using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TripleStrikeL : BasePhysical {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		foreach (Enemy e in targets) {
			success = e.ReduceHealth (LargeDamage (), e.GetShield (), AttackElement ());
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "TripleStrikeL";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + LargeDamage() + "of physical damage to three enemies. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}