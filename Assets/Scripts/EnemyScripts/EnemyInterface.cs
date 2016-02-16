using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

 public abstract class Enemy : Unit {

	public abstract void DoMove(List<Player> players, List<Enemy> enemies);

	protected Player FindLowestPercentageHealth (List<Player> units)
	{
		Player target = units[0];
		foreach (Player u in units) {
			int targetPercentageHp = target.GetCurrentHealth () / target.GetMaxHealth ();
			int nextPercentageHp = u.GetCurrentHealth () / u.GetMaxHealth ();

			if (nextPercentageHp < targetPercentageHp) {
				target = u;
			}
		}

		return target;
	}

	protected Enemy FindLowestPercentageHealth(List<Enemy> units)
	{
		Enemy target = units[0];
		foreach (Enemy u in units) {
			int targetPercentageHp = target.GetCurrentHealth () / target.GetMaxHealth ();
			int nextPercentageHp = u.GetCurrentHealth () / u.GetMaxHealth ();

			if (nextPercentageHp < targetPercentageHp) {
				target = u;
			}
		}

		return target;
	}

}
