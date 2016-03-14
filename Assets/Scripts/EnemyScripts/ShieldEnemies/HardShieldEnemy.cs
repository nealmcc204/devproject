using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

class HardShieldEnemy : ShieldEnemy
{
	public ElementType element;
	static int maxCooldown;
	int cooldown;

	void Awake()
	{
		SetMaxHealth(150);
		SetHealth(GetMaxHealth());
		SetSpeed(100);
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
		Enemy tempEnemy;
		Enemy target = FindLowestPercentageHealth (temp);
		tempEnemy = target;
		element = RandomNewElement ();
		PrimaryMove (target);
		temp.Remove (target);
		target = FindLowestPercentageHealth (temp); //heals 2 different enemies;
		element = RandomNewElement();
		PrimaryMove (target);
		temp.Add(tempEnemy);
	}

	// Update is called once per frame
	void Update()
	{

	}

	private ElementType RandomNewElement()//makes sure the element is not NONE
	{
		ElementType ranEle = RandomElement();
		while (ranEle == ElementType.NONE)
			ranEle = RandomElement ();

		return ranEle;
	}
}
