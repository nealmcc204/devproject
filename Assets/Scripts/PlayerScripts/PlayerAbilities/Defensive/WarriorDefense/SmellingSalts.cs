﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SmellingSalts : DefensiveAbility {

	public override bool Execute(Player target)
	{
		if (target.GetDead()) {
			bool success = false;
			target.Revive ();
			int heal = (int)(target.GetMaxHealth () * 0.1);
			success = target.RestoreHealth (heal);
			return success;
		} else {
			return false;
		}
	}

	public override string GetAbilityTag()
	{
		return "Smelling Salts";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Revives a single target with 10% of their HP."; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}

}