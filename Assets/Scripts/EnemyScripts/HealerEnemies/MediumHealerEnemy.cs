using UnityEngine;
using System.Collections;
using System;

class MediumHealerEnemy : HealerEnemy
{

    void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
        SetSpeed(50);
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