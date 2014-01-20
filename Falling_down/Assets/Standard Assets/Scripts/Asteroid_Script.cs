using UnityEngine;
using System.Collections;

public class Asteroid_Script : MonoBehaviour {
	private GameObject asteroid;
	private FuelGauge fuel;
	// Use this for initialization
	void Start () {
		asteroid = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log("Hit Asteroid");
			Destroy (asteroid);
		}
	}
}
