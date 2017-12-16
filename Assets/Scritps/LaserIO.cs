using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserIO : MonoBehaviour {
	// Use this for initialization
	public GameObject Laser;
	public bool visible;
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		
	}
	void OnBecameVisible() {
		Laser.SetActive (true);
	}
	void OnBecameInvisible() {
		Laser.SetActive (false);
	}
}
