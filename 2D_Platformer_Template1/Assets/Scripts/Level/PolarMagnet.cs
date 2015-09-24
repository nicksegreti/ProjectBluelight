using UnityEngine;
using System.Collections;

public class PolarMagnet : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		if (col.gameObject.tag == "Magnet")
		{
			GlobalVars.isMagnetDisabled = true;
			Destroy(gameObject);

		}
		
	}

	void OnMouseOver()
	{
		if(Input.GetMouseButton(0))
		{
			Vector3 pos = Input.mousePosition;
			pos.z = transform.position.z - Camera.main.transform.position.z;
			transform.position = Camera.main.ScreenToWorldPoint(pos);
		}
	}
}
