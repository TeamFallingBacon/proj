using UnityEngine;
using System.Collections;

public class Pause_menu : MonoBehaviour {
	public GUISkin guiSkin;
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
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space")) {
			pauseToggle();		
		}

	}
	void OnGUI(){
		GUI.skin = guiSkin;
		if (Time.timeScale < 1) {
			GUI.Label (new Rect (Screen.width/2 - 62.0f, Screen.height/2-25.0f, 150, 50), "PAUSED");		
		}
	}
}
