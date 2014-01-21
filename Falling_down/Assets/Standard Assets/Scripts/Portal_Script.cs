using UnityEngine;
using System.Collections;

public class Portal_Script : MonoBehaviour {
	public int finalLevelNumber;
	private GameObject portal;
	private FuelGauge fuel;
	// Use this for initialization
	void Start () {
		portal = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Debug.Log("Enter portal");
			string levelName = Application.loadedLevelName;
			int levelNum = int.Parse(levelName[levelName.Length-1].ToString());
			int newLevelNum;
			Debug.Log ("Level name:" + levelName);
			Debug.Log("Level numstr: " + levelName[levelName.Length-1]);
			Debug.Log ("Level num: " + levelNum);
			//Loop till you get a different level than the current one.. dangerous method but too tired
			do {
				newLevelNum = Random.Range(1,finalLevelNumber+1);
			} while(newLevelNum == levelNum);
			Initialize.slowTime = 1;
			Application.LoadLevel("level" + newLevelNum);
			Destroy (portal);
		}
	}
}
