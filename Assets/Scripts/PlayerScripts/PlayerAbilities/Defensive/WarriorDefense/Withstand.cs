using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Withstand : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetWithstanding (true);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Withstand";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Withstands the next lethal attack, surviving with 1hp"; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}
}