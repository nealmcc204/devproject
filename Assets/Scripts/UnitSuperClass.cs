using UnityEngine;
using System.Collections;

public abstract class Unit : MonoBehaviour {

	// Use this for initialization
	private int health;
	private int maxHealth;
	private int speed;

	//public abstract void Start();

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

	public void RestoreHealth(int h)
	{
		health += h;
		if (health > maxHealth)
			health = maxHealth;
	}

	public void ReduceHealth(int d)
	{
		health -= d;
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
}
