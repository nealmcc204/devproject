using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleWaterM : BaseWater {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (MediumDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.FROZEN);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleWaterM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + MediumDamage() + "of water damage to a single enemy, and freezes them. "; 
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