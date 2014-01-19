using UnityEngine;
using System.Collections;

public class Score_GUI : MonoBehaviour {
	public GUISkin guiSkin;
	public GameObject player;
	public Player_Score score;
	// Use this for initialization
	void Start () {
		score = (Player_Score) player.GetComponent(typeof(Player_Score));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = guiSkin;
		string scoreText = string.Format ("Score: {0}", score.score);
		GUI.Label (new Rect (10, 15, 500, 100), scoreText);
	}
}
