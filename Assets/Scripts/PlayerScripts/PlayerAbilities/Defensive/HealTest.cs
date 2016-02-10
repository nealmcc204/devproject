using UnityEngine;
using System.Collections;

public class HealTest : DefensiveAbility {

	public override void Start()
	{
		SetAbilityTag ("Heal Test");
	}
    
    public override void Execute(Player target)
    {
        int heal = (target.GetMaxHealth() / 4);
		target.RestoreHealth (heal);
    }

}
