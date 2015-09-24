using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject spawn;

	float timer = 0;
	int count = 0;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		timer += Time.deltaTime;

		if(timer > 3 && count < 10)
		{
			timer = 0;
			count += 1;
			GameObject.Instantiate(spawn,transform.position, Quaternion.identity);
		}
	}
}
