using UnityEngine;
using System.Collections;

public abstract class BaseFire : OffensiveAbility {

	protected ElementType AttackElement()
	{
		return ElementType.FIRE;
	}
}
