using UnityEngine;
using System.Collections;
using System;

class WarriorPlayer : Player
{

    // Use this for initialization
    void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
	    SetSpeed(75);
		OffensiveAbility damageTest = new DamageTest ();
		AddOffensiveAbility (damageTest);
		SetShield (ElementType.NONE);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
