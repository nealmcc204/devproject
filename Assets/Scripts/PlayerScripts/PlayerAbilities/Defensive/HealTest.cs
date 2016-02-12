using UnityEngine;
using System.Collections;

public class HealTest : DefensiveAbility {

    public override bool Execute(Player target)
    {
		bool success;
        int heal = (target.GetMaxHealth() / 4);
		success = target.RestoreHealth (heal);
		return success;
    }

	public override string GetAbilityTag()
	{
		return "Heal Test";
	}

}
