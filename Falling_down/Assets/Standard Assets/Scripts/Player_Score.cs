using UnityEngine;
using System.Collections;

public class Player_Score : MonoBehaviour {
	public GameObject camera;
	public int score = 0;
	private FuelGauge fuel;
	// Use this for initialization
	void Start () {
		fuel = (FuelGauge) camera.GetComponent(typeof(FuelGauge));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Portal") {
			Debug.Log("Score + 5000");
			fuel.fuelRemaining += 30.0f;
			score += 5000;
		}
		else if (other.tag == "Item") {
			fuel.fuelRemaining += 5.0f;
			score += 100;
		}
		else if (other.tag == "Asteroid") {
			fuel.fuelRemaining -= 10.0f;
			score -= 200;
		}
	}
}
