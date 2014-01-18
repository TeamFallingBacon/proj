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
		if (generateSpeed)
			movementSpeed = Random.Range(.04f,.08f);
		movementAmount = new Vector3(0,movementSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		fallingObject.transform.position += movementAmount;
	}
}
