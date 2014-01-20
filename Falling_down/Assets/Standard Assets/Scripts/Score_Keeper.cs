using UnityEngine;
using System.Collections;

public class Score_Keeper : MonoBehaviour {
	
	public GameObject player;
	public Player_Score score;
	public int totalScore;
	// Use this for initialization
	void Start () {
		score = (Player_Score) player.GetComponent(typeof(Player_Score));
	}
	
	// Update is called once per frame
	void Update () {
		totalScore = score.score;
	}
}
