using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

	public float speed = 5;
	Vector2 checkpoint;
	Vector2 startpoint;
	Rigidbody2D rigi;
	public Camera mycamera;
	bool is_locked = false;
	// Use this for initialization
	void Start () {
		rigi = transform.GetComponent<Rigidbody2D> ();
		checkpoint = transform.position;
		startpoint = transform.position;
	}
	void changer(){
		if (is_locked) {
			is_locked = false;
			mycamera.transform.parent = null;

		} else {
			is_locked = true;
			mycamera.transform.SetParent (this.transform);
			mycamera.transform.localPosition = new Vector3 (0,0,-5);
		}
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

	public void respawn(){
		transform.position = checkpoint;
	}

	public void save_checkpoint(){
		checkpoint = transform.position;
	}
	// Update is called once per frame
	void Update(){
		movement ();
		if (Input.GetMouseButtonDown(0)) changer();
	}
}
