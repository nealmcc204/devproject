using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public abstract class Player : Unit {

    public List<DefensiveAbility> defensiveAbilities = new List<DefensiveAbility>();
    public List<OffensiveAbility> offensiveAbilities = new List<OffensiveAbility>();

    public void AddOffensiveAbility(OffensiveAbility oa)
    {
        bool present = false;
        foreach (OffensiveAbility i in offensiveAbilities)
        {
			if (i.GetAbilityTag() == oa.GetAbilityTag())
            {
                present = true;
            }
        }
		if (!present) {
			offensiveAbilities.Add (oa);
			Debug.Log ("Ability" + oa.GetAbilityTag () + " added.");
		} else {
			Debug.Log ("Ability" + oa.GetAbilityTag () + " already present.");
		}
    }

    public void RemoveOffensiveAbility(OffensiveAbility oa)
    {
        foreach (OffensiveAbility i in offensiveAbilities) {
			if (i.GetAbilityTag() == oa.GetAbilityTag()) {
				offensiveAbilities.Remove (i);
				break;
			}
        }
    }

    public void AddDefensiveAbility(DefensiveAbility da)
    {
        bool present = false;
        foreach (DefensiveAbility i in defensiveAbilities)
        {
			if (i.GetAbilityTag() == da.GetAbilityTag())
            {
                present = true;
            }
        }
		if (!present) {
			defensiveAbilities.Add (da);
			Debug.Log ("Ability" + da.GetAbilityTag () + " added.");
		} else {
			Debug.Log ("Ability" + da.GetAbilityTag () + " already present.");
		}
    }
    
    public void RemoveDefensiveAbility(DefensiveAbility da)
    {
        foreach (DefensiveAbility i in defensiveAbilities) {
			if (i.GetAbilityTag() == da.GetAbilityTag()) {
				defensiveAbilities.Remove (i);
				break;
			}
        }
    }

    public bool UseAbility(DefensiveAbility ab, Player target)
    {
        return ab.Execute(target);
    }

    public bool UseAbility(OffensiveAbility ab, Enemy target)
    {
        return ab.Execute(target);
    }

	public List<DefensiveAbility> GetDefensiveAbilities()
	{
		return defensiveAbilities;
	}

	public List<OffensiveAbility> GetOffensiveAbilities()
	{
		return offensiveAbilities;
	}
}
