using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class MediumDamageEnemy : DamageEnemy
{

    void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
		SetSpeed(125);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		throw new NotImplementedException ();
    }
		
	public void PrimaryMove(Player target)
    {
		throw new NotImplementedException ();
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
