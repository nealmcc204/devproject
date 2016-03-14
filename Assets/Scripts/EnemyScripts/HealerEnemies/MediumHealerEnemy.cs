using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class MediumHealerEnemy : HealerEnemy
{

    void Awake()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
        SetSpeed(50);
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