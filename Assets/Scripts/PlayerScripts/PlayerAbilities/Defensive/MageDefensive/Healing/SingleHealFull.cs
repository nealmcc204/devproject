using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleHealFull : DefensiveAbility {

	public override bool Execute(Player target)
	{
		bool success = false;
		int heal = (int)(target.GetMaxHealth());
		success = target.RestoreHealth (heal);
		return success;
	}

	public override string GetAbilityTag()
	{
		return "Single Heal Full";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Heals a single friendly target fully."; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}

	public override int GetNumTargets()
	{
		return 1;
	}

}