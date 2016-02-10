using UnityEngine;
using System.Collections;
using System;

class WarriorPlayer : Player
{

    // Use this for initialization
    public override void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
	    SetSpeed(75);
		OffensiveAbility damageTest = new DamageTest ();
		offensiveAbilities.Add (damageTest);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
