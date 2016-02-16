using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class EasyShieldEnemy : ShieldEnemy
{
	public ElementType element; 

    void Start()
    {
        SetMaxHealth(100);
        SetHealth(GetMaxHealth());
        SetSpeed(60);
		SetShield (ElementType.NONE);
    }

	public override void DoMove(List<Player> players, List<Enemy> enemies)
    {
		List<Enemy> targets = new List<Enemy>();
		foreach (Enemy e in enemies) {//checks if enemy is already shielded
			if (e.GetShield ().GetShieldType () == ElementType.NONE) {
				targets.Add (e);
			}
		}
		Enemy target = FindLowestPercentageHealth (targets);
		PrimaryMove (target);
    }

	private void PrimaryMove(Enemy target)
    {
		target.SetShield (element);
		Console.WriteLine ("Shielded ", target.tag);
    }

    private void SpecialMove()
    {
		//Will shield multiple enemies perhaps in Medium difficulty, then will shield with a randomized element in hard.
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {

    }
}