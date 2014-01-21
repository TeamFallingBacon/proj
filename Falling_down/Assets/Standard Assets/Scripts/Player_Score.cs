using UnityEngine;
using System.Collections;

public class Player_Score : MonoBehaviour {
	public GameObject camera;
	public GameObject keeper;
	public Score_Keeper score;
	private FuelGauge fuel;
	// Use this for initialization
	void Start () {
		keeper = GameObject.Find ("ScoreKeeper");
		fuel = (FuelGauge) camera.GetComponent(typeof(FuelGauge));
		score = (Score_Keeper) keeper.GetComponent(typeof(Score_Keeper));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Portal") {
			score.totalScore += 5000;
		}
		else if (other.tag == "Bacon") {
			fuel.fuelRemaining += 2.0f;
			score.totalScore += 100;
		}
		else if (other.tag == "Asteroid") {
			fuel.fuelRemaining -= 15.0f;
			score.totalScore -= 200;
		} else if (other.tag == "Spacecop") {
			fuel.fuelRemaining -= 30.0f;
			score.totalScore -= 5000;
		}
	}
}
