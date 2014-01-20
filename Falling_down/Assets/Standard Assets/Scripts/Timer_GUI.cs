using UnityEngine;
using System.Collections;

public class Timer_GUI : MonoBehaviour {
	public GUISkin guiSkin;
	public GameObject keeper;
	public Score_Keeper start_time;
	public float time_of;
	// Use this for initialization
	void Start () {
		keeper = GameObject.Find ("ScoreKeeper");
		start_time = (Score_Keeper)keeper.GetComponent (typeof(Score_Keeper));
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnGUI(){
		GUI.skin = guiSkin;
		time_of = Time.time - start_time.start_time;
		int minutes = ((int)time_of / 60);
		int seconds = ((int)time_of % 60);
		
		string GUITimeText = string.Format ("Time: {0,2}:{1:00}", minutes, seconds);
		GUI.Label (new Rect (10, 0, 500, 100), GUITimeText);
	}
}
