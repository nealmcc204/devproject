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
		List<Enemy> temp = enemies;
		Enemy tempEnemy;
		Enemy target = FindLowestPercentageHealth (temp);
		PrimaryMove (target);
		tempEnemy = target;
		temp.Remove (target);
		target = FindLowestPercentageHealth (temp); //heals 2 different enemies;
		PrimaryMove (target);
		temp.Add (tempEnemy);

		SetTurnComplete (true);
    }

	private void PrimaryMove(Enemy target)
    {
		int heal = (int)(target.GetMaxHealth()/3);
		target.RestoreHealth(heal);
		string log = "Healed" +target.gameObject.name + " for" + heal;
		Debug.Log (log);
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