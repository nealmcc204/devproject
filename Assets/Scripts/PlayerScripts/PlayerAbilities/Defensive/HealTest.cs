using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class HealTest : DefensiveAbility {

    public override bool Execute(Player target)
    {
		bool success = false;
        int heal = (target.GetMaxHealth() / 4);
		success = target.RestoreHealth (heal);
		return success;
    }

	public override string GetAbilityTag()
	{
		return "Heal Test";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Heals a single friendly target for 25% of their HP."; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}

}
