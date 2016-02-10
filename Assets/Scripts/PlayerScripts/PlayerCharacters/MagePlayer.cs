using UnityEngine;
using System.Collections;
using System;

class MagePlayer : Player 
{
    // Use this for initialization
    public override void Start () {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
        SetSpeed(100);
		DefensiveAbility healTest = new HealTest ();
		AddDefensiveAbility(healTest);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
