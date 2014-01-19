using UnityEngine;
using System.Collections;

public class Pause_menu : MonoBehaviour {
	public GUISkin guiSkin;
	void pause(){
		Time.timeScale = 0.0f;
//		RaycastHit2D[] hits;
//		hits = Physics2D.RaycastAll(transform.position, -Vector2.up);
//		Debug.Log (transform.position);
//		Debug.Log(hits.Length);
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

	}
	void OnGUI(){
		if (GUI.Button (new Rect (Screen.width - 50.0f, 0, 10, 10), "Pause")) {
			pauseToggle ();

		}
		if (Time.timeScale < 1) {
			GUI.Label (new Rect (Screen.width/2 - 25.0f, Screen.height/2 - 0.25f, 50, 50), "PAUSED");		
		}
	}
}
