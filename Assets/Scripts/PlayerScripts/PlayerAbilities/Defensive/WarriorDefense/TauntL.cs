using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TauntL : DefensiveAbility {

	public override bool Execute(Player target)
	{
		target.SetTaunt (true);
		target.SetDamageReduction (0.4f);
		return true;
	}

	public override string GetAbilityTag()
	{
		return "Taunt L";
	}

	public override string GetAbilityDescription()
	{
		string ad = "Forces Enemies to Target this unit until its next turn. Reduces incoming damage by 60%"; 
		return ad;
	}

	public override bool Execute(List<Player> targets)
	{
		return false;
	}
}