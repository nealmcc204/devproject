using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public abstract class OffensiveAbility : BaseAbility {

	public abstract bool Execute (Enemy target);
	public abstract bool Execute(List<Enemy> targets);
	public abstract ElementType AttackElement ();

	protected int SmallDamage()
	{
		return 25;
	}

	protected int MediumDamage()
	{
		return 50;
	}

	protected int LargeDamage()
	{
		return 75;
	}

	protected int HugeDamage()
	{
		return 150;
	}
}
