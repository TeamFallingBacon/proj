using UnityEngine;
using System.Collections;

public class Item_Script : MonoBehaviour {
	private GameObject item;
	private bool shouldSlow = false;
	// Use this for initialization
	void Start () {
		item = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnTriggerEnter2D(Collider2D other) {
		if (item.tag == "Clock" && other.tag == "Player") {
			Debug.Log ("HitClock");
			Destroy(item);
			shouldSlow = true;

		}
		else if (other.tag == "Player") {
			Destroy (item);
		}
	}
	public IEnumerator slowTime (){
		Time.timeScale = 0.5f;
		Debug.Log (Time.timeScale);
		
		Time.timeScale = 1.0f;
		Debug.Log (Time.timeScale);
	}
	void slowTime(){
		Time.timeScale = 0.5f;
		Debug.Log (Time.timeScale);

		Time.timeScale = 1.0f;
		Debug.Log (Time.timeScale);
	}
}
