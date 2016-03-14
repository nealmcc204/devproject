using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class EasyHealerEnemy : HealerEnemy
{

    void Awake()
    {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
        SetSpeed(50);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		Enemy target = FindLowestPercentageHealth (enemies);
		PrimaryMove (target);
		SetTurnComplete (true);
    }

	private void PrimaryMove(Enemy target)
    {
		//Medium difficulty will heal multiple targets.
		int heal = target.GetMaxHealth()/5;
		target.RestoreHealth(heal);
		string log = "Healed" +target.gameObject.name + " for" + heal;
		Debug.Log (log);

    }

    private void SpecialMove()
    {
		//This will be a revive and only present in Hard classes.
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }
}