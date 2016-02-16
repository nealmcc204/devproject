using UnityEngine;
using System.Collections;

public class ShieldTest : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetShield (ElementType.FIRE);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Shield Test";
	}

}