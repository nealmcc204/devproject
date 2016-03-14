using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;

public class WarriorPlayer : Player
{
	public static WarriorPlayer wp;

	void Awake() {//Warrior Player Singleton
		if (!wp) {
			wp = this;
			DontDestroyOnLoad (gameObject);
			SetMaxHealth(100);
			SetHealth(GetMaxHealth());
			SetSpeed(75);
			AddOffensiveAbility (new StunSmashS());
			AddOffensiveAbility (new DoubleStrikeS ());
			SetShield (ElementType.NONE);
		} else {
			Destroy (gameObject);
		}
	}
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

	public override bool ReduceHealth(int damage, Shield s, ElementType ae)
	{
		if (GetTaunting())
			damage = (int) (damage * GetDamageReduction ());

		if (s.GetShieldType() == ElementType.NONE || s.GetShieldType() != ae) {
			SetHealth(GetCurrentHealth() - damage);
			if (GetCurrentHealth () <= 0) {
				if (GetWithstanding ())
					SetHealth (1);
				else {
					SetHealth (0);
					SetDead (true);
				}
			}
			return true;
		} 
		else {
			this.SetShield (ElementType.NONE);
			return false;
		}
	}
}
