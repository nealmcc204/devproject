using UnityEngine;
using System.Collections;

public class MySceneManager : MonoBehaviour {

	public static MySceneManager msc;
	private int levelCounter;

	void Awake() {//Mage Player Singleton
		if (!msc) {
			msc = this;
			DontDestroyOnLoad (gameObject);				
		} else {
			Destroy (gameObject);
		}
	}
}
