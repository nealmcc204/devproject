using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class HardShieldEnemy : ShieldEnemy
{

    void Start()
    {
        SetMaxHealth(150);
        SetHealth(GetMaxHealth());
        SetSpeed(100);
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