using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MageUIControls : MonoBehaviour {

	public GameObject ButtonPrefab;
	public MagePlayer mp;

	GameObject button;
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		BuildUI ();
	}

	public void BuildUI()
	{
		foreach (OffensiveAbility oa in mp.offensiveAbilities) {
			GameObject button = (GameObject)Instantiate (ButtonPrefab, new Vector3 (0f, 0f, 0f), Quaternion.identity);
			button.GetComponentInChildren<Text>().text = oa.GetAbilityTag ();
			//button.GetComponentInChildren<Button>().onClick.AddListener(() => mp.UseAbility(oa,);
		}
	}
}
