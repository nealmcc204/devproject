using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleFireL : BaseFire {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (LargeDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.BURNED);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "Single Fire L";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + LargeDamage() + "of fire damage to a single enemy, and burns them. "; 
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