using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {

	public float speed;
	public float jump;
	private float moveVelocity;
	private bool grounded = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Movement ();
	}

	void Movement() {
		if (Input.GetKey (KeyCode.D) || Input.GetKey (KeyCode.RightArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKey (KeyCode.A) || Input.GetKey (KeyCode.LeftArrow)) {
			GetComponent<Rigidbody2D> ().velocity = new Vector2 (-speed, GetComponent<Rigidbody2D> ().velocity.y);
		}
		if (Input.GetKeyDown (KeyCode.W) || Input.GetKeyDown (KeyCode.Space)) {
			if (grounded) {
				GetComponent<Rigidbody2D> ().velocity = new Vector2 (GetComponent<Rigidbody2D> ().velocity.x, jump);
			}
		}
	}

	void OnCollisionEnter2D() {
		grounded = true;
	}
	void OnCollisionExit2D() {
		grounded = false;
	}
}
