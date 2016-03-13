﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Unit : MonoBehaviour {

	// Use this for initialization
	private int health;
	private int maxHealth;
	private int speed;
	private bool dead;
	private bool taunting;
	private bool withstanding;
	private bool turnComplete;
	private float damageReduction;
	private Shield shield;
	private Status status;


	public abstract void DoMove(List<Player> players, List<Enemy> enemies);

	void Start(){
		shield = new Shield ();
		status = Status.NONE;
	}

	void Update(){
		
	}
	public void SetHealth(int h)
	{
		if (h < maxHealth)
			health = h;
		else
			health = maxHealth;
	}
	
	public int GetCurrentHealth()
	{
		return health;
	}

	public bool RestoreHealth(int h)
	{
		if (!GetDead ()) {
			if (GetStatus () == Status.BURNED) {
				h = h / 2;
				SetStatus (Status.NONE);
			}
			if (health == maxHealth) {
				return false;
			} else {
				health += h;
				if (health > maxHealth)
					health = maxHealth;

				return true;
			}
		} else {
			return false;
		}
	}

	public virtual bool ReduceHealth(int damage, Shield s, ElementType ae)
	{
		if (s.GetShieldType() == ElementType.NONE || s.GetShieldType() != ae) {
			health -= damage;
			if (GetCurrentHealth () <= 0) {
				SetHealth (0);
				SetDead (true);
			}
			return true;
		} 
		else {
			this.SetShield (ElementType.NONE);
			return false;
		}
	}
	
	public int GetMaxHealth()
	{
		return maxHealth;
	}
	
	public void SetMaxHealth(int h)
	{
		maxHealth = h;
	}

	public void SetSpeed(int s)
	{
		speed = s;
	}
	
	public int GetSpeed()
	{
		if (GetStatus () == Status.FROZEN)
			return speed / 2;
		else
			return speed;
	}

	public Shield GetShield()
	{
		return shield;
	}

	public void SetShield(ElementType e)
	{
		if (shield == null) {
			shield = new Shield ();
		}
		shield.SetShieldType (e);
	}

	public bool GetDead()
	{
		return dead;
	}

	public void SetDead(bool d)
	{
		dead = d;
	}

	public void Revive()
	{
		if (GetDead ()) {
			SetDead (false);
		}
	}

	public Status GetStatus()
	{
		return status;
	} 

	public void SetStatus(Status s)
	{
		status = s;
	}

	public bool GetTaunting()
	{
		return taunting;
	}

	public void SetTaunt(bool t)
	{
		taunting = t;
	}

	public float GetDamageReduction()
	{
		return damageReduction;
	}

	public void SetDamageReduction(float dr)
	{
		damageReduction = dr;
	}

	public bool GetWithstanding()
	{
		return withstanding;
	}

	public void SetWithstanding(bool w)
	{
		withstanding = w;
	}

	public void SetTurnComplete(bool t)
	{
		turnComplete = t;
	}

	public bool GetTurnComplete()
	{
		return turnComplete;
	}
}
