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
			StartCoroutine (slowTime (3f));		
		}
	
	}

	public IEnumerator slowTime (float wait){
		while (shouldSlow) {
			Initialize.slowTime = .3f;
			yield return new WaitForSeconds(wait);
			Initialize.slowTime = 1f;
			shouldSlow = false;
		}

	}
}
