using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class EasyDamageEnemy : DamageEnemy {

	int damage;

    void Awake()
    {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
		SetSpeed(100);
		SetShield (ElementType.NONE);
		damage = 20;
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		Player target = GetTaunter (players);

		if(target == null)
			 target = FindLowestPercentageHealth (players);
		
		if (GetStatus () == Status.DAZED) {
			PrimaryMove (target);
			SetStatus (Status.NONE);
		} else {
			PrimaryMove (target);
		}
		SetTurnComplete (true);
    }

	private void PrimaryMove(Player target)
    {
		bool success = false;
		success = target.ReduceHealth (damage, target.GetShield(), ElementType.FIRE);
		if (success) {
			string log = "Damaged" +target.gameObject.name + " for" + damage;
			Debug.Log (log);
		} else {
			Debug.Log ("Attack Blocked.");
		}
    }

    private void SpecialMove()
    {
		//Medium Enemy Will have special Move, which attacks two players. Hard Enemy will hit both, with a random element.
        throw new NotImplementedException();
    }

	// Update is called once per frame
	void Update () {
	
	}
}
