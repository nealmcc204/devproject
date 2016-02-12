using UnityEngine;
using System.Collections;

public class CombatMediator : MonoBehaviour {

	// Use this for initialization
    public PlayerManager playerManager;
    public EnemyManager enemyManager;

	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
       
	}

	public void TestFight()
	{
		Debug.Log ("Aye");
		int health = playerManager.Players[1].GetMaxHealth ();
		bool success;
		//OffensiveAbility myabil = new OffensiveAbility();
		//playerManager.Players [1].UseAbility (myabil, enemyManager.Enemies [1]);

		playerManager.Players[0].SetHealth((playerManager.Players[0].GetMaxHealth() - 50));
		health =  playerManager.Players[0].GetCurrentHealth();

		success = playerManager.Players[1].UseAbility(playerManager.Players[1].defensiveAbilities[0], playerManager.Players[0]);
		health = playerManager.Players[0].GetCurrentHealth();
		string abilitytag =playerManager.Players [1].defensiveAbilities [0].GetAbilityTag ();

		health = enemyManager.Enemies [0].GetCurrentHealth ();
		success = playerManager.Players [0].UseAbility (playerManager.Players [0].offensiveAbilities [0], enemyManager.Enemies [0]);
		health = enemyManager.Enemies [0].GetCurrentHealth ();
 	}
		
}
