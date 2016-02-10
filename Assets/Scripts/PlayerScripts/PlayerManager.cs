using UnityEngine;
using System.Collections;

public class PlayerManager : MonoBehaviour {

    // Use this for initialization
    public Player[] Players = new Player[2];
    
    
    void Start () {
        int numPlayers = 2;
        for (int i = 0; i < numPlayers; i++)
        {
            Players[i].Start();   
        }
    }
    
    // Update is called once per frame
    void Update () {
        
    }
}
;