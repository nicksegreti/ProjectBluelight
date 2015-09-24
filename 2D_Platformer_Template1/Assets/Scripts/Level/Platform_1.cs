using UnityEngine;
using System.Collections;

public class Platform_1 : MonoBehaviour {

	public float MoveSpeed = 0.02f;
	float speed;
	float timer;
	// Use this for initialization
	void Start () 
	{
		speed = MoveSpeed;
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;
		
		if(timer > 5)
		{
			timer = 0;
			if(MoveSpeed == speed)
				MoveSpeed *= -1f;
			else
				MoveSpeed = speed;
		}

		transform.Translate (0, MoveSpeed, 0);
	}
}
