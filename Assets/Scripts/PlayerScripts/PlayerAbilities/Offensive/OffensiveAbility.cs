using UnityEngine;
using System.Collections;

public abstract class OffensiveAbility : BaseAbility {
	public abstract bool Execute(Enemy target);
}
