using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleEarthM : BaseEarth {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (MediumDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.DAZED);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleEarthM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + MediumDamage() + "of Earth damage to a single enemy, and dazes them. "; 
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