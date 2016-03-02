using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class WarriorPlayer : Player
{
	public static WarriorPlayer wp;

	void Awake() {//Warrior Player Singleton
		if (!wp) {
			wp = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
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

	public override void DoMove(List<Player> players, List<Enemy> enemies)
	{
		UseAbility (offensiveAbilities [0], enemies [0]);
	}
}
