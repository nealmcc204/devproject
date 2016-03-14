using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UnitInfo : MonoBehaviour {

	int maxHealth;
	public GameObject healthBar;
	Vector3 healthScale;
	string healthText;
	Unit self;

	// Use this for initialization
	void Start () {
		self = gameObject.GetComponentInParent<Unit> ();
		maxHealth = self.GetMaxHealth ();
		healthScale = new Vector3 (1f, 1f, 1f);
		healthText = maxHealth + "/" + maxHealth;
		gameObject.GetComponentInChildren<Text> ().text = healthText;
		healthBar.transform.localScale = healthScale; 
	}
	
	// Update is called once per frame
	void Update () {
		healthScale.x = GetPercentageHealth ();
		healthBar.transform.localScale = healthScale;
		UpdateHealthText ();
		gameObject.GetComponentInChildren<Text> ().text = healthText;
		UpdateHealthColour ();

	}

	public float GetPercentageHealth()
	{
		float percent = ((float)gameObject.GetComponentInParent<Unit> ().GetCurrentHealth ()) / (float)maxHealth;
		return percent;
	}

	public void UpdateHealthText()
	{
		healthText = gameObject.GetComponentInParent<Unit> ().GetCurrentHealth () + "/" + maxHealth;
	}

	public void UpdateHealthColour()
	{
		switch (self.GetStatus ()) {

		case Status.BURNED:
			healthBar.GetComponent<Image> ().color = new Color (1f, 0.5f, 0f);
			break;

		case Status.FROZEN:
			healthBar.GetComponent<Image> ().color = Color.cyan;
			break;

		case Status.DAZED:
			healthBar.GetComponent<Image> ().color = Color.yellow;
			break;

		case Status.STUNNED:
			healthBar.GetComponent<Image> ().color = Color.grey;
			break;

		default:
			healthBar.GetComponent<Image> ().color = Color.green;
			break;
		}
	}
}
