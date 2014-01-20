using UnityEngine;
using System.Collections;

public class Item_Script : MonoBehaviour {
	private GameObject item;
	// Use this for initialization
	void Start () {
		item = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Destroy (item);
		}
	}
}
