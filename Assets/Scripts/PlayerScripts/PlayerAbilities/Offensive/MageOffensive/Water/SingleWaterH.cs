using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleWaterH : BaseWater {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (HugeDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.FROZEN);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleWaterH";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + HugeDamage() + "of water damage to a single enemy, and freezes them. "; 
		return ad;
	}

	public override bool Execute(List<Enemy> targets)
	{
		return false;
	}

	public override int GetNumTargets()
	{
		return 1;
	}
}