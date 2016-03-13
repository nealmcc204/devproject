using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleFireM : BaseFire {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (MediumDamage(), target.GetShield(), AttackElement() );
		target.SetStatus (Status.BURNED);
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "SingleFireM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + MediumDamage() + "of fire damage to a single enemy. "; 
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