using UnityEngine;
using System.Collections;

public class Destroyer : MonoBehaviour {
	GameObject destroyer;
	// Use this for initialization
	void Start () {
		destroyer = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log("Hit something!");
		Destroy(other.gameObject);
	}
}
