using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleEarthH : BaseEarth {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (HugeDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.DAZED);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleEarthH";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + HugeDamage() + "of Earth damage to a single enemy, and dazes them. "; 
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