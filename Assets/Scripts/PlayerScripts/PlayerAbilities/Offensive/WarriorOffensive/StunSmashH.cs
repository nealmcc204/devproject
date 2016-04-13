﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class StunSmashH : BasePhysical {

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (HugeDamage(), target.GetShield(), AttackElement() );
		if (success) {
			target.SetStatus (Status.STUNNED);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "Stun Smash H";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + HugeDamage() + "of physical damage to a single enemy, and stuns them. "; 
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