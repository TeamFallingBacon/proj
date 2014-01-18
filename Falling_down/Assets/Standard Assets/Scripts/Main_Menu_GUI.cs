using UnityEngine;
using System.Collections;

public class Main_Menu_GUI : MonoBehaviour {
	public GUISkin guiSkin;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnGUI() {

		GUI.skin = guiSkin;
		GUI.Label (new Rect (Screen.width*0.41f, Screen.height * 0.20f, 100, 50), "Main Menu");
		if (GUI.Button (new Rect (Screen.width/2 - 50.0f, Screen.height/2 - 25.0f, 100, 50), "Start")) {
			Application.LoadLevel ("level1");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 50.0f, Screen.height / 2 + 50.0f - 25.0f, 100, 50), "Exit")) {
			Application.Quit();		
		}
	}
}
