using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReceiverCode : MonoBehaviour {

	public GameObject targetGO;

	private DetectionCode detectionCode;
	// Use this for initialization
	void Start () 
	{
		detectionCode = targetGO.GetComponent<DetectionCode> ();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (detectionCode.detector == true)
			GetComponent<SpriteRenderer> ().color = Color.black;
			Debug.Log ("Bridge Open");
		if (detectionCode.detector == false)
			GetComponent<SpriteRenderer> ().color = Color.white;
			Debug.Log ("No bridge for you");

	}
}
