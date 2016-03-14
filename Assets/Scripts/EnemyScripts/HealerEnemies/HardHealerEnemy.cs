using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class HardHealerEnemy : HealerEnemy
{
	int cooldown;
	static int maxCooldown;

    void Awake()
    {
        SetMaxHealth(125);
        SetHealth(GetMaxHealth());
        SetSpeed(75);
		maxCooldown = 2;
		cooldown = maxCooldown;
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
	{
		if (GetStatus () == Status.DAZED || cooldown > 0 || !CheckForDeadAllies(enemies)){
			List<Enemy> temp = enemies;
			Enemy tempEnemy;
			Enemy target = FindLowestPercentageHealth (temp);
			tempEnemy = target;
			PrimaryMove (target);
			temp.Remove (target);
			target = FindLowestPercentageHealth (temp); //heals 2 different enemies;
			PrimaryMove (target);
			temp.Add(tempEnemy);
			cooldown--;
		} else {
			foreach (Enemy e in enemies) {
				if (e.GetDead ()) {
					SpecialMove (e);

					cooldown = maxCooldown;
					SetTurnComplete (true);
					return;
				}
			}
		}
		SetTurnComplete (true);
	}

	private void PrimaryMove(Enemy target)
	{
		int heal = (int)(target.GetMaxHealth()/2);
		target.RestoreHealth(heal);
		string log = "Healed" +target.gameObject.name + " for" + heal;
		Debug.Log (log);
	}


	private void SpecialMove(Enemy target)
    {
		target.SetDead (false);//revives and heals enemy
		PrimaryMove (target);
    }

    // Update is called once per frame
    void Update()
    {

    }

	private bool CheckForDeadAllies(List<Enemy> enemies)
	{
		foreach (Enemy e in enemies) {
			if (e.GetDead ())
				return true;
		}
		return false;
	}
}