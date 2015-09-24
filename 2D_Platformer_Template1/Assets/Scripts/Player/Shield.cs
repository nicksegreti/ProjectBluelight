using UnityEngine;
using System.Collections;

public class Shield : MonoBehaviour {

	Vector2 target;
	float baseNum = 0.1f;
	
	// Use this for initialization
	void Start () 
	{
		transform.localScale = new Vector3 (baseNum * GlobalVars.RespectPoints, baseNum * GlobalVars.RespectPoints, 1);
		ChangeColor ();
	}
	
	// Update is called once per frame
	void Update () 
	{

		if(Input.GetKeyDown(KeyCode.R))
		{
			GlobalVars.RespectPoints += 1;

		}
		target = GameObject.FindGameObjectWithTag("Player").transform.position;

		transform.localScale = new Vector3 (baseNum * GlobalVars.RespectPoints, baseNum * GlobalVars.RespectPoints, 1);
		transform.position = new Vector2(target.x,target.y);
	}

	void ChangeColor()
	{
		if(GlobalVars.RespectPoints >= 5)
		{
			GetComponent <SpriteRenderer>().color = Color.blue;
		}
	}
}
