using UnityEngine;
using System.Collections;

public class Pause_menu : MonoBehaviour {
	public GUISkin guiSkin;
	public GameObject camera;
	private FuelGauge fuel;

	void pause(){
		Time.timeScale = 0.0f;
	}
	void unpause(){
		Time.timeScale = 1.0f;
	}
	void pauseToggle(){
		if (Time.timeScale > 0) {
			pause ();		
		} else {
			unpause ();		
		}
	}
		
	
	// Use this for initialization
	void Start () {
		unpause ();
		fuel = (FuelGauge) camera.GetComponent(typeof(FuelGauge));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			pauseToggle();		
		}

	}
	void OnGUI(){
		GUI.skin = guiSkin;
		if (fuel.gameOver) {
			pause ();
			GUI.Label (new Rect (Screen.width/2-100.0f, Screen.height/2-25.0f, 250, 50), "GAME OVER");
			if (GUI.Button(new Rect (Screen.width/2 - 62.0f, Screen.height/2+25.0f, 150, 50), "RESTART")) {
				GameObject scoreKeeper = GameObject.Find ("ScoreKeeper");
				if (scoreKeeper)
					Destroy(GameObject.Find ("ScoreKeeper"));
				Application.LoadLevel("level1");
			}
			if (GUI.Button(new Rect (Screen.width/2 - 62.0f, Screen.height/2+85.0f, 150, 50), "MAIN MENU")) {
				GameObject scoreKeeper = GameObject.Find ("ScoreKeeper");
				if (scoreKeeper)
					Destroy(GameObject.Find ("ScoreKeeper"));
				Application.LoadLevel("main_menu");
			}
		}
		
		else if (Time.timeScale < 1) {
			GUI.Label (new Rect (Screen.width/2 - 65.0f, Screen.height/2-25.0f, 170, 50), "PAUSED");
			if (GUI.Button(new Rect (Screen.width/2 - 62.0f, Screen.height/2+25.0f, 150, 50), "MAIN MENU")) {
				GameObject scoreKeeper = GameObject.Find ("ScoreKeeper");
				if (scoreKeeper)
					Destroy(GameObject.Find ("ScoreKeeper"));
				Application.LoadLevel("main_menu");
			}
		}
	}
}
