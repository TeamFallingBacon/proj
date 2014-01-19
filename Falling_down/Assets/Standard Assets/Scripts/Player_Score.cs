using UnityEngine;
using System.Collections;

public class Player_Score : MonoBehaviour {
	public int score = 0;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Portal") {
			Debug.Log("Score + 100");
			score += 100;
		}
	}
}
