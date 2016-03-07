using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleWaterL : BaseWater {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (LargeDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.FROZEN);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleWaterL";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + LargeDamage() + "of water damage to a single enemy, and freezes them. "; 
		return ad;
	}

	public override bool Execute(List<Enemy> targets)
	{
		return false;
	}
}