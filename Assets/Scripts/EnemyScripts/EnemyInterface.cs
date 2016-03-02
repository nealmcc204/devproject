using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

 public abstract class Enemy : Unit {

	protected Player FindLowestPercentageHealth (List<Player> units)
	{
		if (units.Count == 0)
			return null;
		
		Player target = units[0];
			
		float targetPercentageHp = 2;
		foreach (Player u in units) {
			float nextPercentageHp = (float)u.GetCurrentHealth () / (float)u.GetMaxHealth ();
			if (nextPercentageHp < targetPercentageHp) {
				target = u;
			}
			targetPercentageHp = (float)target.GetCurrentHealth () / (float)target.GetMaxHealth ();
		}
		return target;
	}

	protected Enemy FindLowestPercentageHealth(List<Enemy> units)
	{
		if (units.Count == 0)
			return null;

		Enemy target = units[0];
			
		float targetPercentageHp = 2;
		foreach (Enemy u in units) {
			float nextPercentageHp = (float)u.GetCurrentHealth () / (float)u.GetMaxHealth ();
			if (nextPercentageHp < targetPercentageHp) {
				target = u;
			}
			targetPercentageHp = (float)target.GetCurrentHealth () / (float)target.GetMaxHealth ();
		}

		return target;
	}

}
