using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class SingleFireShield : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetShield (ElementType.FIRE);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Single Fire Shield";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Shields a single friendly target against a single Fire attack."; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}


}