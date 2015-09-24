using UnityEngine;
using System.Collections;

public class PlayerBehavior : MonoBehaviour {
	
	public GameObject Shield;
	bool useShield = false;
	public float coolDown = 0;
	// Use this for initialization
	void Start () 
	{
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(useShield)
		{
			coolDown += Time.deltaTime;
			if(coolDown > 10){coolDown = 0; useShield = false;}
		}
		if(Input.GetKeyDown(KeyCode.Space) && !useShield && coolDown == 0)
		{
			useShield = true;
			GameObject.Instantiate(Shield,transform.position, Quaternion.identity);
		}
		else if(Input.GetKeyDown(KeyCode.Space) && useShield || coolDown > 5)
		{
			//useShield = false;
			Destroy(GameObject.FindGameObjectWithTag("Shield"));
		}

		if(Input.GetKeyDown(KeyCode.M))
		{
			if(GlobalVars.isMagnetDisabled)
				GlobalVars.isMagnetDisabled = false;
			else
				GlobalVars.isMagnetDisabled = true;
		}


		if(GlobalVars.isPlayerLocked)
			GetComponent <Rigidbody2D>().isKinematic = true;
		else
			GetComponent <Rigidbody2D>().isKinematic = false;

	}
	
}
