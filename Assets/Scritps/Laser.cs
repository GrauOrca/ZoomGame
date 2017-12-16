﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D col){
		Debug.Log ("There's a collision");
		if (col.gameObject.tag == "Player") {
			col.gameObject.GetComponent<PlayerMovement> ().respawn ();
		}
	}

}
