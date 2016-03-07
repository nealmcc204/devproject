﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TripleFireM : BaseFire {

	public override bool Execute(List<Enemy> targets)
	{
		bool success = false;
		for (int i = 0; i < 3; i++) {
			success = targets [i].ReduceHealth (MediumDamage (), targets [i].GetShield (), AttackElement ());
			if (success) {
				targets[i].SetStatus (Status.BURNED);
			}		
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "TripleFireM";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + MediumDamage() + "of fire damage to three enemies. "; 
		return ad;
	}

	public override bool Execute (Enemy target)
	{
		return false;
	}
}