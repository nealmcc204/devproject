using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class MediumShieldEnemy : ShieldEnemy
{
	public ElementType element;
	static int maxCooldown;
	int cooldown;

    void Awake()
    {
        SetMaxHealth(125);
        SetHealth(GetMaxHealth());
        SetSpeed(80);
		cooldown = 0;
		maxCooldown = 2;
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		if (GetStatus () == Status.DAZED || cooldown > 0) {
			Enemy target = FindLowestPercentageHealth (enemies);
			PrimaryMove (target);
			cooldown--;
		} else {
			SpecialMove (enemies);
			cooldown = maxCooldown;
		}
		SetTurnComplete (true);
    }

	private void PrimaryMove(Enemy target)
    {
		target.SetShield (element);
		string log = "Shielded" +target.gameObject.name;
		Debug.Log (log);
    }

	private void SpecialMove(List<Enemy> enemies)
    {
		List<Enemy> temp = enemies;
		Enemy target = FindLowestPercentageHealth (temp);
		PrimaryMove (target);
		temp.Remove (target);
		target = FindLowestPercentageHealth (temp); //heals 2 different enemies;
		PrimaryMove (target);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
