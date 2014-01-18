using UnityEngine;
using System.Collections;

public class FuelGauge : MonoBehaviour {
	public Vector2 pos = new Vector2(250,10);
	public float fuelTotal = 100;
	public float fuelRemaining = 100;
	private float barwidth;
	public Texture2D frontground;
	public Texture2D background;

	void Start() {
		barwidth = Screen.width/4 * (fuelRemaining/fuelTotal) * Time.timeScale;
	}
	
	void OnGUI() {
		GUI.DrawTexture(new Rect(pos.x, pos.y, Screen.width/4, 20), background);
		GUI.DrawTexture(new Rect(pos.x, pos.y, barwidth, 20), frontground);
	}
	
	void Update() {
		barwidth = (Screen.width/4) * (fuelRemaining/fuelTotal) * Time.timeScale;
		fuelRemaining -= .1f;
		if (fuelRemaining <= 0) {
			fuelRemaining = 0;
		}
	}
}
