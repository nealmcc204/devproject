using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class MediumDamageEnemy : DamageEnemy
{
	int damage;
	int cooldown;
	static int maxCooldown;
	ElementType element;

    void Awake()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
		SetSpeed(125);
		SetShield (ElementType.NONE);
		damage = 40;
		maxCooldown = 2;
		cooldown = maxCooldown;
		element = ElementType.FIRE;
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
					SpecialMove (players);
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
		
	public void PrimaryMove(Player target)
    {
		bool success = false;
		success = target.ReduceHealth (damage, target.GetShield(), element);
		if (success) {
			string log = "Damaged" +target.gameObject.name + " for" + damage;
			Debug.Log (log);
		} else {
			Debug.Log ("Attack Blocked.");
		}
    }

	private void SpecialMove(List<Player> targets)
    {
		foreach (Player t in targets) {
			PrimaryMove (t);
		}
			
    }

    // Update is called once per frame
    void Update()
    {

    }
}
