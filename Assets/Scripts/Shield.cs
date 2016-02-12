using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	// Use this for initialization
	ElementType shield;

	void Start () {
		shield = ElementType.NONE;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void SetShieldType(ElementType e)
	{
		shield = e;
	}

	public ElementType GetShieldType()
	{
		return shield;
	}
}
