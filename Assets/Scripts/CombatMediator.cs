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
		/*Debug.Log ("Aye");
		int health = playerManager.Players[1].GetMaxHealth ();
		bool success;

		playerManager.Players[0].SetHealth((playerManager.Players[0].GetMaxHealth() - 50));
		health =  playerManager.Players[0].GetCurrentHealth();

		success = playerManager.Players[1].UseAbility(playerManager.Players[1].defensiveAbilities[0], playerManager.Players[0]);
		health = playerManager.Players[0].GetCurrentHealth();
		string abilitytag =playerManager.Players [1].defensiveAbilities [0].GetAbilityTag ();

		success = playerManager.Players [1].UseAbility (playerManager.Players [1].defensiveAbilities [1], playerManager.Players [0]);
		Shield shield = playerManager.Players [0].GetShield ();

		health = enemyManager.Enemies [0].GetCurrentHealth ();
		success = playerManager.Players [0].UseAbility (playerManager.Players [0].offensiveAbilities [0], enemyManager.Enemies [0]);
		health = enemyManager.Enemies [0].GetCurrentHealth ();

		enemyManager.Enemies [0].DoMove (playerManager.Players, enemyManager.Enemies);*/
		foreach (Enemy e in enemyManager.Enemies) {
			e.DoMove (playerManager.Players, enemyManager.Enemies);
		}
		Debug.Log ("Execution Complete.");
	}
}
