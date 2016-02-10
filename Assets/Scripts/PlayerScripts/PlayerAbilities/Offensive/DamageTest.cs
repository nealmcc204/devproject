﻿using UnityEngine;
using System.Collections;

public class DamageTest : OffensiveAbility {

	public override void Start()
	{
		SetAbilityTag ("Damage Test");
	}

	public override void Execute(Enemy target)
	{
		target.ReduceHealth (20);
	}
}
