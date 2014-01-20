﻿using UnityEngine;
using System.Collections;

public class Portal_Script : MonoBehaviour {
	private GameObject portal;
	private FuelGauge fuel;
	// Use this for initialization
	void Start () {
		portal = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log("Enter portal");
			Application.LoadLevel("level2");
			Destroy (portal);
		}
	}
}
