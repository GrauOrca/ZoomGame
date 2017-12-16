using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectionCode : MonoBehaviour {

	public bool detector;


	// Use this for initialization
	void Start () 
	{
		
	}

	// Update is called once per frame
	void Update () 
	{
		// **Actions if seen**
		if (detector == true)
			Debug.Log ("Inside");

		// **Actions if NOT seen**
		else if (detector == false)
			Debug.Log("Outside");
	}

	void OnBecameVisible()
	{
		detector = true;
	}

	void OnBecameInvisible()
	{
		detector = false;
	}
}
