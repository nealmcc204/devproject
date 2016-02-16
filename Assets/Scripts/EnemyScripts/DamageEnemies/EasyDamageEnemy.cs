using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class EasyDamageEnemy : DamageEnemy {

    void Start()
    {
        SetMaxHealth(75);
        SetHealth(GetMaxHealth());
		SetSpeed(100);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		Player target = FindLowestPercentageHealth (players);
		PrimaryMove (target);
    }

	private void PrimaryMove(Player target)
    {
		target.ReduceHealth (20, target.GetShield(), ElementType.FIRE);
		Console.WriteLine("Damaged", target.tag, "for 20");
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
