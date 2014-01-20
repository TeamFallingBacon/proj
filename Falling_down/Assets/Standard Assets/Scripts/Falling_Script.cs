using UnityEngine;
using System.Collections;

public class Falling_Script : MonoBehaviour {
	private GameObject fallingObject;
	public bool generateSpeed = false;
	public float movementSpeed = 0;
	private Vector3 movementAmount;
	// Use this for initialization
	void Start () {
		fallingObject = gameObject;
		if (generateSpeed) {
			movementSpeed = Random.Range(.08f,.12f);
			if (Application.loadedLevelName == "level3") //Reversed the direction in level 3
				movementSpeed *= -1;
		}
		movementAmount = new Vector3(0,movementSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		if (fallingObject.tag == "Bacon")
			fallingObject.transform.position += movementAmount * Time.deltaTime*100;
		else
			fallingObject.transform.position += movementAmount * Time.deltaTime*100 * Initialize.slowTime;
	}
}