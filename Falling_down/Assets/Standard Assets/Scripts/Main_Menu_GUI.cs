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
		GUI.Label (new Rect (Screen.width/2 - 50.0f, Screen.height * 0.17f, 150, 50), "<size=50>Title</size>");
		GUI.Label (new Rect (Screen.width/2 - 80.0f, Screen.height * 0.35f, 250, 50), "<size=35>MAIN MENU</size>");
		if (GUI.Button (new Rect (Screen.width/2 - 50.0f, Screen.height/2 - 25.0f, 100, 50), "START")) {
			Application.LoadLevel ("level1");
		}
		if (GUI.Button (new Rect (Screen.width / 2 - 50.0f, Screen.height / 2 + 60.0f - 25.0f, 100, 50), "EXIT")) {
			Application.Quit();		
		}
	}
}
