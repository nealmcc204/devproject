using UnityEngine;
using System.Collections;

public class DamageTest : OffensiveAbility {

	public override bool Execute(Enemy target)
	{
		bool success;
		ElementType attackElement = ElementType.FIRE;
		success = target.ReduceHealth (20, target.GetShield(), attackElement);
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "Damage Test";
		return at;
	}
}
