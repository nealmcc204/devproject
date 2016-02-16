using UnityEngine;
using System.Collections;
using System;

class MagePlayer : Player 
{
    // Use this for initialization
    void Start () {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
        SetSpeed(100);
		DefensiveAbility healTest = new HealTest ();
		DefensiveAbility shieldTest = new ShieldTest ();
		AddDefensiveAbility(healTest);
		AddDefensiveAbility (shieldTest);
		SetShield (ElementType.NONE);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
