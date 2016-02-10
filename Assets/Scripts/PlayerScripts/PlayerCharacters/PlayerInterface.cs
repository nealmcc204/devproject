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
            if (i == oa)
            {
                present = true;
            }
        }
        if (!present)
            offensiveAbilities.Add(oa); 
    }

    public void RemoveOffensiveAbility(OffensiveAbility oa)
    {
        foreach (OffensiveAbility i in offensiveAbilities) {
            if(i == oa)
                offensiveAbilities.Remove(i);
        }
    }

    public void AddDefensiveAbility(DefensiveAbility da)
    {
        bool present = false;
        foreach (DefensiveAbility i in defensiveAbilities)
        {
            if (i == da)
            {
                present = true;
            }
        }
        if (!present)
        defensiveAbilities.Add(da);
    }
    
    public void RemoveDefensiveAbility(DefensiveAbility da)
    {
        foreach (DefensiveAbility i in defensiveAbilities) {
            if(i == da)
                defensiveAbilities.Remove(i);
        }
    }

    public void UseAbility(DefensiveAbility ab, Player target)
    {
        ab.Execute(target);
    }

    public void UseAbility(OffensiveAbility ab, Enemy target)
    {
        ab.Execute(target);
    }
}
