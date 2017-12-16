using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTrigger2DEnter(Collider2D col){
		if (col.gameObject.tag == "Player") {
			Debug.Log ("There's a Player in the road");
		}
	}

}
