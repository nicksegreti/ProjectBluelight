using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float moveSpeed = 0.01f;

	private float moveHorizontal = 0f;

	public float jumpHeight = 500f;
	//public bool isJumping = false;
	bool isGrounded = true;

	Rigidbody2D rb;
	// Use this for initialization
	void Start () 
	{
		rb = gameObject.GetComponent<Rigidbody2D> ();


	}
	
	// Update is called once per frame
	void Update () 
	{

		//Horizontal Movement
		moveHorizontal = Input.GetAxis ("Horizontal");
		//Jump
		if (Input.GetButtonDown("Fire1") && isGrounded)
		{
			rb.AddForce(Vector2.up * jumpHeight);
			isGrounded = false;
		}
			
		rb.velocity = new Vector2 (moveHorizontal * moveSpeed, rb.velocity.y);
	}
	void OnCollisionEnter2D(Collision2D col)
	{
		if(col.gameObject.tag == "Ground" || col.gameObject.tag == "Enemy" || col.gameObject.tag == "Platform")
		{
			isGrounded = true;
		}
	}
}
