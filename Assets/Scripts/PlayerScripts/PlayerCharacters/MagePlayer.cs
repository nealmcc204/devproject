﻿using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class MagePlayer : Player 
{
	public static MagePlayer mp;

	void Awake() {//Mage Player Singleton
		if (!mp) {
			mp = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}
    // Use this for initialization
    void Start () {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
        SetSpeed(100);
		AddOffensiveAbility(new SingleFireS());
		AddOffensiveAbility (new SingleEarthS());
		AddOffensiveAbility (new SingleWaterS());
		AddDefensiveAbility (new SingleHealS());
		SetShield (ElementType.NONE);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public override void DoMove(List<Player> players, List<Enemy> enemies)
	{
		UseAbility (defensiveAbilities [0], players [0]);
	}
}
