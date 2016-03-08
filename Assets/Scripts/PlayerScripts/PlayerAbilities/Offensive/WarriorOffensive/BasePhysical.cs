using UnityEngine;
using System.Collections;

public abstract class BasePhysical : OffensiveAbility {

	protected ElementType AttackElement()
	{
		return ElementType.NONE;
	}
}

