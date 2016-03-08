using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TauntS : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetTaunt (true);
		target.SetDamageReduction (0.75f);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Taunt S";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Forces Enemies to Target this unit until its next turn. Reduces incoming damage by 25%"; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}
}