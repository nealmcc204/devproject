using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine.UI;

public abstract class Player : Unit {

    public List<DefensiveAbility> defensiveAbilities = new List<DefensiveAbility>();
    public List<OffensiveAbility> offensiveAbilities = new List<OffensiveAbility>();
	private List<Enemy> selectedEnemyTargets = new List<Enemy>();
	private List<Player> selectedFriendlyTargets = new List<Player> ();
	private OffensiveAbility selectedOffensiveAbility;
	private DefensiveAbility selectedDefensiveAbility;
	private BaseAbility selectedAbility;
	public GameObject buttonPrefab;
	public Canvas canvas;
	private List<GameObject> buttons = new List<GameObject> ();

    public void AddOffensiveAbility(OffensiveAbility oa)
    {
        bool present = false;
        foreach (OffensiveAbility i in offensiveAbilities)
        {
			if (i.GetAbilityTag() == oa.GetAbilityTag())
            {
                present = true;
            }
        }
		if (!present) {
			offensiveAbilities.Add (oa);
			Debug.Log ("Ability" + oa.GetAbilityTag () + " added.");
		} else {
			Debug.Log ("Ability" + oa.GetAbilityTag () + " already present.");
		}
    }

    public void RemoveOffensiveAbility(OffensiveAbility oa)
    {
        foreach (OffensiveAbility i in offensiveAbilities) {
			if (i.GetAbilityTag() == oa.GetAbilityTag()) {
				offensiveAbilities.Remove (i);
				break;
			}
        }
    }

    public void AddDefensiveAbility(DefensiveAbility da)
    {
        bool present = false;
        foreach (DefensiveAbility i in defensiveAbilities)
        {
			if (i.GetAbilityTag() == da.GetAbilityTag())
            {
                present = true;
            }
        }
		if (!present) {
			defensiveAbilities.Add (da);
			Debug.Log ("Ability" + da.GetAbilityTag () + " added.");
		} else {
			Debug.Log ("Ability" + da.GetAbilityTag () + " already present.");
		}
    }
    
    public void RemoveDefensiveAbility(DefensiveAbility da)
    {
        foreach (DefensiveAbility i in defensiveAbilities) {
			if (i.GetAbilityTag() == da.GetAbilityTag()) {
				defensiveAbilities.Remove (i);
				break;
			}
        }
    }

    public bool UseAbility(DefensiveAbility ab, List<Player> targets)
    {
		bool result = false;

		foreach(Player p in targets)
        	result = ab.Execute(p);

		return result;
    }

    public bool UseAbility(OffensiveAbility ab, List<Enemy> targets)
    {
		bool result = false;

		foreach (Enemy e in targets)
          result = ab.Execute(e);

		return result;
    }

	public List<DefensiveAbility> GetDefensiveAbilities()
	{
		return defensiveAbilities;
	}

	public List<OffensiveAbility> GetOffensiveAbilities()
	{
		return offensiveAbilities;
	}

	public void SetSelectedOffensiveAbility(OffensiveAbility oa)
	{
		selectedOffensiveAbility = oa;
		selectedAbility = oa;
	}

	public OffensiveAbility GetSelectedOffensiveAbility()
	{
		return selectedOffensiveAbility;
	}

	public void SetSelectedDefensiveAbility(DefensiveAbility da)
	{
		selectedDefensiveAbility = da;
		selectedAbility = da;
	}

	public DefensiveAbility GetSelectedDefensiveAbility()
	{
		return selectedDefensiveAbility;
	}
		
	public BaseAbility GetSelectedAbility()
	{
		return selectedAbility;
	}

	public void ResetSelectedAbilities()
	{
		selectedOffensiveAbility = null;
		selectedDefensiveAbility = null;
		selectedAbility = null;
	}

	public void ResetSelectedTargets()
	{
		selectedEnemyTargets.Clear ();
		selectedFriendlyTargets.Clear ();
	}

	public override void DoMove(List<Player> players, List<Enemy> enemies)
	{
		offensiveAbilities.TrimExcess ();
		defensiveAbilities.TrimExcess ();
		players.TrimExcess ();
		enemies.TrimExcess ();
		StartCoroutine(TakeTurn(players,enemies));
	}

	IEnumerator TakeTurn(List<Player> players, List<Enemy> enemies)
	{
		//UseAbility (defensiveAbilities [0], players [0]);
		int numTargets;
		CreateTurnAbilityButtons();
		while (GetSelectedOffensiveAbility () == null && GetSelectedDefensiveAbility() == null) {
			yield return null;
		}
		RemoveButtons ();
		if (GetSelectedAbility () is OffensiveAbility) {
			
			numTargets = GetSelectedOffensiveAbility ().GetNumTargets ();
			if (numTargets > GetNumLivingEnemies (enemies))
				numTargets = GetNumLivingEnemies (enemies);
			
			CreateEnemyTargetButtons (enemies);

			while (numTargets > selectedEnemyTargets.Count) {
				yield return null;
			}
			RemoveButtons ();
			UseAbility (GetSelectedOffensiveAbility (), selectedEnemyTargets);

		} 

		else {
			numTargets = GetSelectedDefensiveAbility ().GetNumTargets ();
			if (numTargets == 1) {
				CreatePlayerTargetButtons (players);

				while (numTargets > selectedFriendlyTargets.Count) {
					yield return null;
				}
				RemoveButtons ();
				UseAbility (GetSelectedDefensiveAbility (), selectedFriendlyTargets);
			} else {
				UseAbility (GetSelectedDefensiveAbility (), players);
			}
		}
		ResetSelectedAbilities ();
		ResetSelectedTargets ();
		SetTurnComplete (true);
	}

	public void CreateTurnAbilityButtons()
	{

		GameObject button;
		foreach (OffensiveAbility oa in offensiveAbilities) {
			button = (GameObject)Instantiate (buttonPrefab, new Vector3(0,0,0), Quaternion.identity);
			button.GetComponentInChildren<Text> ().text = oa.GetAbilityTag ();
			button.GetComponentInChildren<Button> ().onClick.AddListener(() => SetSelectedOffensiveAbility (oa));
			button.transform.SetParent (canvas.transform);
			buttons.Add (button);
		}

		foreach (DefensiveAbility da in defensiveAbilities) {
			button = (GameObject)Instantiate (buttonPrefab, new Vector3(0,0,0), Quaternion.identity);
			button.GetComponentInChildren<Text> ().text = da.GetAbilityTag ();
			button.GetComponentInChildren<Button> ().onClick.AddListener(() => SetSelectedDefensiveAbility (da));
			button.transform.SetParent (canvas.transform);
			buttons.Add (button);
		}
	}

	public void CreateEnemyTargetButtons(List<Enemy> targets)
	{
		GameObject button;
		foreach (Enemy t in targets) {
			button = (GameObject)Instantiate (buttonPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
			button.GetComponentInChildren<Text> ().text = t.name;
			button.GetComponentInChildren<Button> ().onClick.AddListener (() => AddToSelectedEnemyTargets (t));
			button.transform.SetParent (canvas.transform);
			buttons.Add (button);
		}
	}

	public void CreatePlayerTargetButtons(List<Player> targets)
	{
		GameObject button;
		foreach (Player t in targets) {
			button = (GameObject)Instantiate (buttonPrefab, new Vector3 (0, 0, 0), Quaternion.identity);
			button.GetComponentInChildren<Text> ().text = t.name;
			button.GetComponentInChildren<Button> ().onClick.AddListener (() => AddToSelectedFriendlyTargets (t));
			button.transform.SetParent (canvas.transform);
			buttons.Add (button);
		}
	}

	public void AddToSelectedEnemyTargets(Enemy target)
	{
		foreach(Enemy e in selectedEnemyTargets)//dont add same target twice
		{
			if (e == target)
				return;
		}
		selectedEnemyTargets.Add (target);
	}

	public void AddToSelectedFriendlyTargets(Player target)
	{
		foreach(Player p in selectedFriendlyTargets)//dont add same target twice
		{
			if (p == target)
				return;
		}
		selectedFriendlyTargets.Add (target);
	}

	public int GetNumLivingEnemies(List<Enemy> enemies)
	{
		int count = 0;
		foreach (Enemy e in enemies) {
			if (!e.GetDead ())
				count++;
			}
		return count;
	}

	public void RemoveButtons()
	{
		foreach (GameObject g in buttons) {
			Destroy (g);
		}
	}
}
