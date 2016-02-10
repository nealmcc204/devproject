using UnityEngine;
using System.Collections;

public class CombatMediator : MonoBehaviour {

	// Use this for initialization
    public PlayerManager playerManager;
    public EnemyManager enemyManager;
    private int numEnemies;

	void Start () {
        numEnemies = enemyManager.GetNumberEnemies();
        int health = playerManager.Players[1].GetMaxHealth ();
        //OffensiveAbility myabil = new OffensiveAbility();
        //playerManager.Players [1].UseAbility (myabil, enemyManager.Enemies [1]);

		playerManager.Players[0].SetHealth((playerManager.Players[0].GetMaxHealth() - 50));
		health =  playerManager.Players[0].GetCurrentHealth();

		playerManager.Players[1].UseAbility(playerManager.Players[1].defensiveAbilities[0], playerManager.Players[0]);
		health = playerManager.Players[0].GetCurrentHealth();

		health = enemyManager.Enemies [0].GetCurrentHealth ();
		playerManager.Players [0].UseAbility (playerManager.Players [0].offensiveAbilities [0], enemyManager.Enemies [0]);
		health = enemyManager.Enemies [0].GetCurrentHealth ();
	}
	
	// Update is called once per frame
	void Update () {
       
	}
}
