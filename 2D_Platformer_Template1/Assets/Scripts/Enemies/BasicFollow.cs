using UnityEngine;
using System.Collections;

public class BasicFollow : MonoBehaviour {

	public float EnemySpeed = 2.0f;
	Vector2 target;

	public bool stopNearby;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		target = GameObject.FindGameObjectWithTag("Player").transform.position;

		//move this object towards the player
		if(stopNearby)
		{
			if(Vector3.Distance(transform.position, target) > 3)
				transform.position = Vector2.MoveTowards(transform.position, new Vector3(target.x, 0), EnemySpeed  * Time.deltaTime);
		}
		else
		{
			if(Vector3.Distance(transform.position, target) < 15)
				transform.position = Vector2.MoveTowards(transform.position, new Vector3(target.x, 0), EnemySpeed  * Time.deltaTime);
		}
	}
}
