﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DamageTest : OffensiveAbility {

	int damage = 50;
	ElementType attackElement = ElementType.EARTH;

	public override bool Execute(Enemy target)
	{
		bool success = false;
		success = target.ReduceHealth (damage, target.GetShield(), attackElement);
		return success;
	}

	public override bool Execute(List<Enemy> targets)
	{
		return false;
	}

	public override string GetAbilityTag()
	{
		string at = "Damage Test";
		return at;
	}

	public override string GetAbilityDescription()
	{
		string ad = "Deals" + damage + "of Earth damage to target. "; 
		return ad;
	}
}
