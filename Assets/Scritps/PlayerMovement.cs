using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5;
	Rigidbody2D rigi;
	public Vector2 Horizontal;
	public Vector2 Vertical;
	// Use this for initialization
	void Start () {
		rigi = transform.GetComponent<Rigidbody2D> ();
	}

	void movement(){
		if (Input.GetKey (KeyCode.W)) {
			rigi.MovePosition (new Vector2(transform.position.x,transform.position.y  + speed));
		}
		if (Input.GetKey (KeyCode.S)) {
			rigi.MovePosition (new Vector2(transform.position.x,transform.position.y  - speed));
		}
		if (Input.GetKey (KeyCode.A)) {
			rigi.MovePosition (new Vector2(transform.position.x - speed,transform.position.y));
		}
		if (Input.GetKey (KeyCode.D)) {
			rigi.MovePosition (new Vector2(transform.position.x + speed,transform.position.y));

		}
	}		
	// Update is called once per frame
	void Update(){
		movement ();
	}
}
