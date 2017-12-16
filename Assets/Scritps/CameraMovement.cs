using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {


	// Use this for initialization
	void Start () 
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y, -5);
	}

	// Update is called once per frame
	void Update () 
	{
		var d = Input.GetAxis ("Mouse ScrollWheel");
		if (d > 0f)
			Camera.main.fieldOfView = Camera.main.fieldOfView + 1;
		else if (d < 0f)
			Camera.main.fieldOfView = Camera.main.fieldOfView - 1;

		if (Input.GetKeyDown("d"))
			transform.position =  new Vector3(transform.position.x + 1,transform.position.y, transform.position.z);
		if (Input.GetKeyDown("a"))
			transform.position =  new Vector3(transform.position.x - 1,transform.position.y, transform.position.z);
		if (Input.GetKeyDown("s"))
			transform.position =  new Vector3(transform.position.x,transform.position.y - 1, transform.position.z);
		if (Input.GetKeyDown("w"))
			transform.position =  new Vector3(transform.position.x,transform.position.y + 1, transform.position.z);


			}
	}
