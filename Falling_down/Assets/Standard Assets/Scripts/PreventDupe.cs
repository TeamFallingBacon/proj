using UnityEngine;
using System.Collections;

public class PreventDupe : MonoBehaviour {

	//Prevents duplicate scorekeepers
	void Awake () {
		if (GameObject.Find("ScoreKeeper") != gameObject)
			DestroyImmediate(gameObject);
	}

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
