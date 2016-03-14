using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class HardTankEnemy : TankEnemy
{

    void Awake()
    {
        SetMaxHealth(250);
        SetHealth(GetMaxHealth());
        SetSpeed(30);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
        throw new NotImplementedException();
    }

    private void PrimaryMove()
    {
        throw new NotImplementedException();
    }

    private void SpecialMove()
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }
}