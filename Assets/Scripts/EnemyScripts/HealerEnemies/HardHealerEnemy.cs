using UnityEngine;
using System.Collections;
using System;

class HardHealerEnemy : HealerEnemy
{

    public override void Start()
    {
        SetMaxHealth(125);
        SetHealth(GetMaxHealth());
        SetSpeed(75);
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