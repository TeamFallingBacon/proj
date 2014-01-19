using UnityEngine;
using System.Collections;

public class FuelGauge : MonoBehaviour {
	public Vector2 pos = new Vector2(250,10);
	public float fuelTotal = 100;
	public float fuelRemaining = 100;
	private float barwidth;
	public Texture2D frontground;
	public Texture2D background;
	public bool gameOver = false;
	void Start() {
		barwidth = Screen.width / 3 * (fuelRemaining / fuelTotal);// * Time.timeScale;
	}
	
	void OnGUI() {
		GUI.DrawTexture(new Rect(pos.x, pos.y, Screen.width/3, 20), background);
		GUI.DrawTexture(new Rect(pos.x, pos.y, barwidth, 20), frontground);
	}
	
	void Update() {
		if (Time.timeScale > 0.0f) {
			barwidth = (Screen.width / 3) * (fuelRemaining / fuelTotal);// * Time.timeScale;
			//fuelRemaining -= .15f;
			if (fuelRemaining > 0) {
				fuelRemaining -= .1f;
			}
			else {
				//Time.timeScale = 0;
				gameOver = true;
			}	
		}

	}
}
