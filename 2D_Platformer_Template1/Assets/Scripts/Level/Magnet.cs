using UnityEngine;
using System.Collections;

public class Magnet : MonoBehaviour {

	public float PullSpeed;
	public float Range;
	GameObject player;
	float dist = 0;


	// Use this for initialization
	void Start () 
	{
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!GlobalVars.isMagnetDisabled) 
		{
			dist = Vector2.Distance (transform.position, player.transform.position);

			if(dist < 0.1f)
			{
				GlobalVars.isPlayerLocked = true;
			}
			else if (dist < Range)
				player.transform.position = Vector3.MoveTowards (player.transform.position, transform.position, PullSpeed / dist);

		}
		else
			GlobalVars.isPlayerLocked = false;
	}


}
