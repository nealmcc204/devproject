﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AllWaterS : BaseWater {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		foreach (Enemy e in targets) {
			success = e.ReduceHealth (SmallDamage(), e.GetShield(), AttackElement() );
			if (success) {
				e.SetStatus (Status.FROZEN);
			}
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "AllWaterS";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of water damage to all enemies. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}

	public override int GetNumTargets()
	{
		return 6;
	}
}