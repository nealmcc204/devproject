using UnityEngine;
using System.Collections;

public abstract class OffensiveAbility : BaseAbility {
    public abstract void Execute(Enemy target);
}
