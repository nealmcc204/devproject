﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TripleWaterS : BaseWater {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 3; i++) {
			success = targets [i].ReduceHealth (SmallDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.FROZEN);
			}		
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "TripleWaterS";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + SmallDamage() + "of water damage to three enemies. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}