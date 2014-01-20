using UnityEngine;
using System.Collections;

public class Score_Keeper : MonoBehaviour {
	
	public GameObject player;
	public GameObject keeper;
	public Player_Score score;
	public int totalScore = 0;
	public float start_time;
	// Use this for initialization
	void Start () {
		start_time = Time.time;
		keeper = GameObject.Find ("ScoreKeeper");
	}
	
	// Update is called once per frame
	void Update () {

	}
	void Awake(){
		Object.DontDestroyOnLoad (keeper);
	}
}
