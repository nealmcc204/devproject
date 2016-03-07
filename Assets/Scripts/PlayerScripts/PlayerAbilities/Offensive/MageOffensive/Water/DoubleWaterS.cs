﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleWaterS : BaseWater {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 2; i++) {
			success = targets [i].ReduceHealth (SmallDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.FROZEN);
			}
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "DoubleWaterM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of water damage to two enemies. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}