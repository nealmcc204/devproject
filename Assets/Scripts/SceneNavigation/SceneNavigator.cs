using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneNavigator : MonoBehaviour {

	// Use this for initialization
	public static SceneNavigator sn;
	int currentLevelNum;

	void Awake() {//Mage Player Singleton
		if (!sn) {
			sn = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
	}

	void Start () {
		currentLevelNum = 1;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void GoToMainMenu()
	{
		SceneManager.LoadScene ("StartScreen");
	}

	public void GoToInstructions()
	{
		SceneManager.LoadScene ("Instructions");
	}

	public void GoToLevel1()
	{
		SceneManager.LoadScene ("Level1");
	}

	public void GoToLevel2()
	{
		SceneManager.LoadScene ("Level2");
	}

	public void GoToLevel3()
	{
		SceneManager.LoadScene ("Level3");
	}

	public void GoToLevel4()
	{
		SceneManager.LoadScene ("Level4");
	}

	public void GoToLevel5()
	{
		SceneManager.LoadScene ("Level5");
	}

	public void GoToLevel6()
	{
		SceneManager.LoadScene ("Level6");
	}

	public void GoToMageFireAbilities()
	{
		SceneManager.LoadScene ("MageFireAbilitiesScreen");
	}

	public void GoToMageHealingAbilities()
	{
		SceneManager.LoadScene ("MageHealingAbilities");
	}

	public void GoToMageWaterAbilities()
	{
		SceneManager.LoadScene ("MageWaterAbilitiesScreen");
	}

	public void GoToMageEarthAbilities()
	{
		SceneManager.LoadScene ("ManageMageAbilities");
	}

	public void GoToWarriorDefensiveAbilities()
	{
		SceneManager.LoadScene ("WarriorDefensiveAbilitiesScreen");
	}

	public void GoToWarriorOffensiveAbilities()
	{
		SceneManager.LoadScene ("WarriorOffensive");
	}

	public void GoToVictoryScreen()
	{
		SceneManager.LoadScene ("VictoryScreen");
	}

	public void GoToDefeatScreen()
	{
		SceneManager.LoadScene ("DefeatScreen");
	}

	public void GoToNextLevel()
	{
		currentLevelNum++;
		string nextLevel = "Level" + currentLevelNum;
		SceneManager.LoadScene (nextLevel);
	}

	public void RestartLevel()
	{
		string currentLevel = "Level" + currentLevelNum;
		SceneManager.LoadScene (currentLevel);
	}

	public void GoToPreScreen()
	{
		SceneManager.LoadScene ("PreScreen");
	}
}
