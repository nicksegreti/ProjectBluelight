using UnityEngine;
using System.Collections;

public class HUD : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI()
	{
		GUI.Label (new Rect (10, 10, 100, 100), "Respect: " + GlobalVars.RespectPoints.ToString());
	}
}
