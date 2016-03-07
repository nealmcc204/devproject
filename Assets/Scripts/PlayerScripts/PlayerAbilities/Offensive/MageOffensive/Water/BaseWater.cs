using UnityEngine;
using System.Collections;

public abstract class BaseWater : OffensiveAbility {

	protected ElementType AttackElement()
	{
		return ElementType.WATER;
	}
}
