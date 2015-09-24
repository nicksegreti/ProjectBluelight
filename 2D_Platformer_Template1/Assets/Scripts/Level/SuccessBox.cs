using UnityEngine;
using System.Collections;

public class SuccessBox : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if(col.gameObject.tag == "Player")
		{
			GlobalVars.RespectPoints += 1;
			Destroy(gameObject);
		}
	}
}
