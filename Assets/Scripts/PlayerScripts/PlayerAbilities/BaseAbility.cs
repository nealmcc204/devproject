using UnityEngine;
using System.Collections;

public abstract class BaseAbility {
	
	private string abilityTag;

	public abstract void Start();

	public string GetAbilityTag()
	{
		return abilityTag;
	}

	public void SetAbilityTag(string t)
	{
		abilityTag = t;
	}
}
