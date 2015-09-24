using UnityEngine;
using System.Collections;

public class FixGrav : MonoBehaviour {

	
	void Update () 
	{
		if(transform.rotation != Quaternion.identity)
		{
			transform.rotation = Quaternion.identity;
		}
	}
}
