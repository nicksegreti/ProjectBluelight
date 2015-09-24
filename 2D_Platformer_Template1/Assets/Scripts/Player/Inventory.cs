using UnityEngine;
using System.Collections;

public class Inventory : MonoBehaviour {
	
	//Item Array
	public GameObject[] BackPackItems;
	//BackPack Location
	public Vector3 BackPack = new Vector3 (0, 20, 0);

	
	void Start () 
	{

		BackPackItems = GameObject.FindGameObjectsWithTag ("Backpack");
	}

	void Update ()
	{
		//Every fame updates array
		BackPackItems = GameObject.FindGameObjectsWithTag ("Backpack");

		//Button Press for removal
		if(Input.GetKeyDown(KeyCode.J) && BackPackItems.Length > 0)
		   RemoveInventoryItem(BackPackItems[0]);

		/* Other Button for specific item retrieval
		if(Input.GetKeyDown(KeyCode.O) && BackPackItems.Length > 1)
			RemoveInventoryItem(BackPackItems[1]);

		if(Input.GetKeyDown(KeyCode.I)  && BackPackItems.Length > 2)
			RemoveInventoryItem(BackPackItems[2]);

		if(Input.GetKeyDown(KeyCode.U)  && BackPackItems.Length > 3)
			RemoveInventoryItem(BackPackItems[3]);

		if(Input.GetKeyDown(KeyCode.Y)  && BackPackItems.Length > 4)
			RemoveInventoryItem(BackPackItems[4] );
			//*/
	}

	void OnCollisionEnter2D(Collision2D col)
	{
		//If collision with any Gameobject with Tag "Item"
		if(col.gameObject.tag == "Item" && BackPackItems.Length < 5)
		{
			AddInventoryItem(col.gameObject);
		}
	}

	//Adds gameobject to "Backpack"
	void AddInventoryItem(GameObject newItem)
	{
		newItem.tag = "Backpack";
		SwitchOff (newItem);
	}

	//Removes gameobject from "BackPack"
	void RemoveInventoryItem(GameObject newItem)
	{
		newItem.tag = "Item";
		SwitchOn (newItem);
	}

	//Destroys Item 
	void UseInventoryItem(GameObject newItem)
	{
		Destroy(newItem);
	}

	//Sets Item to BackPack
	void SwitchOff(GameObject newItem)
	{
		if(newItem.GetComponent <Rigidbody2D>().isKinematic != true)
			newItem.GetComponent <Rigidbody2D>().isKinematic = true;

		if (newItem.transform.position != BackPack)
			newItem.transform.position = BackPack;

		if (newItem.GetComponent <Collider2D> ().enabled != false)
			newItem.GetComponent <Collider2D> ().enabled = false;
	}
	//Sets Item back from BackPack
	void SwitchOn(GameObject newItem)
	{
		newItem.transform.position = new Vector3(transform.position.x+3, transform.position.y,0);

		if(newItem.GetComponent <Rigidbody2D>().isKinematic != false)
			newItem.GetComponent <Rigidbody2D>().isKinematic = false;

		if (newItem.GetComponent <Collider2D> ().enabled != true)
			newItem.GetComponent <Collider2D> ().enabled = true;
	}

	//General switch function
	void SwitchItem(GameObject newItem)
	{
		//ChangePosition
		if (newItem.transform.position != BackPack)
			newItem.transform.position = BackPack;
		else
			newItem.transform.position = transform.position;

		//Lock Rigidbody
		if(newItem.GetComponent <Rigidbody2D>().isKinematic == false)
			newItem.GetComponent <Rigidbody2D>().isKinematic = true;
		else
			newItem.GetComponent <Rigidbody2D>().isKinematic = false;

		//Disable collider box
		if (newItem.GetComponent <Collider2D> ().enabled == false)
			newItem.GetComponent <Collider2D> ().enabled = true;
		else
			newItem.GetComponent <Collider2D> ().enabled = false;

	}
}
