using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleFireS : BaseFire {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (SmallDamage(), target.GetShield(), AttackElement() );
		target.SetStatus (Status.BURNED);
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleFireS";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of fire damage to a single enemy. "; 
		return ad;
	}

	public override bool Execute(List<Enemy> targets)
	{
		return false;
	}
}