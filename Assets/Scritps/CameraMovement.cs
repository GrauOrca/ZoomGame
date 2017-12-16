using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour 
{

	public float maxFOV = 160;
	public float minFOV = 0;
	void Start () 
	{
		transform.position = new Vector3 (transform.position.x, transform.position.y, -5); // Initial Position
	}


	void Update () 
	{
		// **Zoom Code**
		var d = Input.GetAxis ("Mouse ScrollWheel");

		if ((d > 0f) && ( Camera.main.fieldOfView < maxFOV))
			Camera.main.fieldOfView = Camera.main.fieldOfView + 10;
			// Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, Camera.main.fieldOfView + 10, 2*Time.deltaTime);
		else if ((d < 0f) && (Camera.main.fieldOfView > minFOV))
			Camera.main.fieldOfView = Camera.main.fieldOfView - 10;
			// Camera.main.fieldOfView = Mathf.Lerp (Camera.main.fieldOfView, Camera.main.fieldOfView - 10, 2*Time.deltaTime);

		// **Camera Movement Code** 
		if (Input.GetKeyDown("d"))
			transform.position =  new Vector3(transform.position.x + 1,transform.position.y, transform.position.z);
		if (Input.GetKeyDown("a"))
			transform.position =  new Vector3(transform.position.x - 1,transform.position.y, transform.position.z);
		if (Input.GetKeyDown("s"))
			transform.position =  new Vector3(transform.position.x,transform.position.y - 1, transform.position.z);
		if (Input.GetKeyDown("w"))
			transform.position =  new Vector3(transform.position.x,transform.position.y + 1, transform.position.z);

		// **Detection Code
	
	}
}
