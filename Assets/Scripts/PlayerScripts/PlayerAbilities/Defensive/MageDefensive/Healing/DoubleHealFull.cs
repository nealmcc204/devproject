using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DoubleHealS : DefensiveAbility {

	public override bool Execute(List<Player> targets)
	{
		bool success = false;
		foreach (Player p in targets) {
			int heal = (p.GetMaxHealth ());
			success = p.RestoreHealth(heal);
		}
		return success;
	}

	public override string GetAbilityTag()
	{
		return "Double Heal S";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Heals both friendly targets fully."; 
		return ad;
	}

	public override bool Execute(Player target)
	{
		return false;
	}
}