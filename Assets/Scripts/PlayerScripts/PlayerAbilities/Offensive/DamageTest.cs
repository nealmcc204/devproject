using UnityEngine;
using System.Collections;

public class DamageTest : OffensiveAbility {

	public override bool Execute(Enemy target)
	{
		bool success;
		ElementType attackElement = ElementType.EARTH;
		success = target.ReduceHealth (60, target.GetShield(), attackElement);
		return success;
	}

	public override string GetAbilityTag()
	{
		string at = "Damage Test";
		return at;
	}
}
