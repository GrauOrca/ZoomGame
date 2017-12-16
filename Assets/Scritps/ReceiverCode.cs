using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverCode : MonoBehaviour {

	public GameObject targetGO;

	private DetectionCode detectionCode;
	// Use this for initialization
	void Start () 
	{
		// **Selects the DetectionCode script**
		detectionCode = targetGO.GetComponent<DetectionCode> ();
	}
	
	// Update is called once per frame
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
