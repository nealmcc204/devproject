using UnityEngine;
using System.Collections;

public abstract class DefensiveAbility : BaseAbility {
    public abstract bool Execute(Player target);
}
