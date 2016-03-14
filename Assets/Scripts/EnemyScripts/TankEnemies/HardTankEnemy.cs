using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class HardTankEnemy : TankEnemy
{
	static int maxCooldown;
	int cooldown;
	int damage;

    void Awake()
    {
        SetMaxHealth(250);
        SetHealth(GetMaxHealth());
        SetSpeed(30);
		cooldown = 0;
		maxCooldown = 2;
		damage = 40;
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		Player target = GetTaunter (players);

		if (target == null) {
			target = FindLowestPercentageHealth (players);
			if (GetStatus () == Status.DAZED) {
				PrimaryMove (target);
				SetStatus (Status.NONE);
			} else {
				if (cooldown <= 0) {
					SpecialMove ();
					cooldown = maxCooldown;
				} else {
					PrimaryMove (target);
					cooldown--;
				}
			}
		} else {
			PrimaryMove (target);
			cooldown--;
		}
		SetTurnComplete (true);
    }

	private void PrimaryMove(Player target)
    {
		target.ReduceHealth (damage, target.GetShield(), ElementType.NONE);
		string log = "Damaged" +target.gameObject.name + " for" + damage;
		Debug.Log (log);
    }

    private void SpecialMove()
    {
		SetTaunt (true);
    }

    // Update is called once per frame
    void Update()
    {

    }
}