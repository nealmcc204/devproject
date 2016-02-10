using UnityEngine;
using System.Collections;

public class EnemyManager : MonoBehaviour {

    // Use this for initialization
    public int numEnemies;
    public Enemy[] Enemies = new Enemy[10];
    

    void Start () {
        
        for (int i = 0; i < numEnemies; i++)
        {
            Enemies[i]. Start();   
        }

        int health =  Enemies[0].GetCurrentHealth();
        health = Enemies[1].GetCurrentHealth();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public int GetNumberEnemies()
    {
        return numEnemies;
    }
}