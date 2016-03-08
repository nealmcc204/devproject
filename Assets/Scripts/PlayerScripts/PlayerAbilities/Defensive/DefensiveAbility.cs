using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class DefensiveAbility : BaseAbility {
    public abstract bool Execute(Player target);
	public abstract bool Execute(List<Player> targets); 
}
