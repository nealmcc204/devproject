using UnityEngine;
using System.Collections;

public abstract class BaseEarth : OffensiveAbility {

	protected ElementType AttackElement()
	{
		return ElementType.EARTH;
	}
}

