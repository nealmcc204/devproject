using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleHealM : DefensiveAbility {

	public override bool Execute(Player target)
	{
		bool success = false;
		int heal = (int)(target.GetMaxHealth() * (2/3));
		success = target.RestoreHealth (heal);
		return success;
	}

	public override string GetAbilityTag()
	{
		return "Single Heal M";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Heals a single friendly target for 66% of their HP."; 
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