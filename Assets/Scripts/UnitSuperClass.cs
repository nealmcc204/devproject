using UnityEngine;
using System.Collections;

public abstract class Unit : MonoBehaviour {

	// Use this for initialization
	private int health;
	private int maxHealth;
	private int speed;
	public Shield shield;

	void Start(){
		shield = new Shield ();
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
			return true;
		} 
		else {
			this.SetShield (ElementType.NONE);
			return false;
		}
		//if health <= 0 then dead;
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
}
