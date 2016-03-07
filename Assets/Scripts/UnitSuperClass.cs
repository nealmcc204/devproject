using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public abstract class Unit : MonoBehaviour {

	// Use this for initialization
	private int health;
	private int maxHealth;
	private int speed;
	private bool dead;
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
		if (health == maxHealth) {
			return false;
		} else {
			health += h;
			if (health > maxHealth)
				health = maxHealth;

			return true;
		}
	}

	public bool ReduceHealth(int damage, Shield s, ElementType ae)
	{
		if (s.GetShieldType() == ElementType.NONE || s.GetShieldType() != ae) {
			health -= damage;
			if (GetCurrentHealth () <= 0) {
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

	public bool IsDead()
	{
		return dead;
	}

	private void SetDead(bool d)
	{
		dead = d;
	}

	public void Revive()
	{
		if (IsDead ()) {
			SetDead (false);
			SetHealth ((int)(GetMaxHealth () * 0.2));
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
}
