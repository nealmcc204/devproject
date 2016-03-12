using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class WeakHeal : DefensiveAbility {

	public override bool Execute(Player target)
	{
		bool success = false;
		int heal = (int)(target.GetMaxHealth() / 8);
		success = target.RestoreHealth (heal);
		return success;
	}

	public override string GetAbilityTag()
	{
		return "Weak Heal";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Heals a single friendly target for 12.5% of their HP."; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}

}
