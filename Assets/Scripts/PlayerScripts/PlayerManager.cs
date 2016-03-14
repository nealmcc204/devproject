using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PlayerManager : MonoBehaviour {

    // Use this for initialization
	public GameObject magePrefab;
	public GameObject warriorPrefab;

	public List<Player> Players = new List<Player>();
    
    
    void Awake () {
		GameObject character;
		character = (GameObject)Instantiate (magePrefab, new Vector3 (0, 0, 0), Quaternion.identity);
		Players [0] = character.GetComponentInChildren<MagePlayer>();
		character = (GameObject)Instantiate (warriorPrefab, new Vector3 (50, 0, 0), Quaternion.identity);
		Players [1] = character.GetComponentInChildren<WarriorPlayer> ();
    }
    
    // Update is called once per frame
    void Update () {
        
    }
}
;