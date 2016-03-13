using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleWaterShield : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetShield (ElementType.WATER);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Single Water Shield";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Shields a single friendly target against a single Water attack."; 
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