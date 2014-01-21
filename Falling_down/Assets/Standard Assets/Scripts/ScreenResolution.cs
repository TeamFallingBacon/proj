using UnityEngine;
using System.Collections;

public class ScreenResolution : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void Awake(){
		Screen.SetResolution (500, 500, false);
	}
}
