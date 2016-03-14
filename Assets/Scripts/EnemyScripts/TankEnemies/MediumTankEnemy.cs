using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class MediumTankEnemy : TankEnemy
{
	int damage;

    void Awake()
    {
        SetMaxHealth(200);
        SetHealth(GetMaxHealth());
        SetSpeed(30);
		damage = 30;
		SetShield (ElementType.NONE);
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
		target.ReduceHealth (damage, target.GetShield(), ElementType.NONE);
		string log = "Damaged" +target.gameObject.name + " for" + damage;
		Debug.Log (log);
	}

	private void SpecialMove()
	{
		//will taunt at Hard(?) difficulties, forcing players to attack it. May also gain element damage.
		throw new NotImplementedException();
	}

	// Update is called once per frame
	void Update()
	{

	}
}