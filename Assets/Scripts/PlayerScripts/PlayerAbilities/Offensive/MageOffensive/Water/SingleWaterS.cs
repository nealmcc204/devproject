using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleWaterS : BaseWater {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (SmallDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.FROZEN);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleWaterS";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of water damage to a single enemy, and freezes them. "; 
		return ad;
	}

	public override bool Execute(List<Enemy> targets)
	{
		return false;
	}
}