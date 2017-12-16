using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverCode : MonoBehaviour {

	public GameObject targetGO;
	private DetectionCode detectionCode;
	bool isInside;

	void Start () 
	{
		// **Selects the DetectionCode script**
		detectionCode = targetGO.GetComponent<DetectionCode> ();
	}


	void OnTriggerEnter2D(Collider2D col)
	{
		Debug.Log ("There's a collision");
		if (col.gameObject.tag == "Player") 
		{
			isInside = true;
		}
	}
	

	void Update () 
	{
		// **Block Receives TRUE information**
		if (detectionCode.detector == true) // Uses the detector variable from the Detection Code script
			GetComponent<Rigidbody2D> ().simulated = false;
			Debug.Log ("Bridge Open");

		// **Block Receives FALSE information from **
		if (detectionCode.detector == false)
			GetComponent<Rigidbody2D> ().simulated = true;
			Debug.Log ("No bridge for you");

	}
}
