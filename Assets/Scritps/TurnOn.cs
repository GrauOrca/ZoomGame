using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnOn : MonoBehaviour {

	GameObject trigger;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameVisible()
	{
		trigger.GetComponent<counter> ().greens++;
	}

	void OnBecameInvisible()
	{
		trigger.GetComponent<counter> ().greens--;
	}

}
