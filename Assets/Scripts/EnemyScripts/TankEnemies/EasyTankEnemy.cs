using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class EasyTankEnemy : TankEnemy
{

    void Awake()
    {
        SetMaxHealth(150);
        SetHealth(GetMaxHealth());
        SetSpeed(30);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		Player target = FindLowestPercentageHealth (players);
		PrimaryMove (target);
		SetTurnComplete (true);
    }

	private void PrimaryMove(Player target)
    {
		target.ReduceHealth (10, target.GetShield(), ElementType.NONE);
		string log = "Damaged" +target.gameObject.name + " for 10";
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