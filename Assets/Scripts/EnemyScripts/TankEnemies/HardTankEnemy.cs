﻿using UnityEngine;
using System.Collections;
using System;

class HardTankEnemy : TankEnemy
{

    void Start()
    {
        SetMaxHealth(250);
        SetHealth(GetMaxHealth());
        SetSpeed(30);
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
    void Update()
    {

    }
}