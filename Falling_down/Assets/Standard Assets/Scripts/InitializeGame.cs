using UnityEngine;
using System.Collections;

public class InitializeGame : MonoBehaviour {
	private GameObject scoreKeeper;
	// Use this for initialization
	void Start () {
		//scoreKeeper = gameObject.Find("ScoreKeeper");
		if (GameObject.Find("ScoreKeeper")) {
			//Destroy(
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
