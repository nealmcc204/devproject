﻿using UnityEngine;
using System.Collections;
using System;

class EasyDamageEnemy : DamageEnemy {

    public override void Start()
    {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
		SetSpeed(100);
    }

    public override void DoMove()
    {
        throw new NotImplementedException();
    }

    public override void PrimaryMove()
    {
        throw new NotImplementedException();
    }

    public override void SpecialMove()
    {
        throw new NotImplementedException();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
