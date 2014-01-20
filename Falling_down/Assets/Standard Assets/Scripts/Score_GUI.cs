using UnityEngine;
using System.Collections;

public class Score_GUI : MonoBehaviour {
	public GUISkin guiSkin;
	public GameObject keeper;
	public Score_Keeper score;
	// Use this for initialization
	void Start () {
		keeper = GameObject.Find ("ScoreKeeper");
		score = (Score_Keeper) keeper.GetComponent(typeof(Score_Keeper));
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnGUI(){
		GUI.skin = guiSkin;
		string scoreText = string.Format ("Score: {0}", score.totalScore);
		GUI.Label (new Rect (10, 15, 500, 100), scoreText);
	}
}
