using UnityEngine;
using System.Collections;
using System;

class MediumDamageEnemy : DamageEnemy
{

    void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
		SetSpeed(125);
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
