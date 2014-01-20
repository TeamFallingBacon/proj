using UnityEngine;
using System.Collections;

public class ClockSlow : MonoBehaviour {
	
	public bool shouldSlow = false;
	// Use this for initialization
	void Start () {
		shouldSlow = false;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (shouldSlow) {
			StartCoroutine (slowTime (0.0f));		
		}
	
	}

	public IEnumerator slowTime (float wait){
		while (shouldSlow) {
			Time.timeScale = 0.5f;
			Debug.Log (Time.timeScale);
			yield return new WaitForSeconds(1.5f);
			Time.timeScale = 1.0f;
			Debug.Log (Time.timeScale);
			shouldSlow=false;
		}

	}
}
