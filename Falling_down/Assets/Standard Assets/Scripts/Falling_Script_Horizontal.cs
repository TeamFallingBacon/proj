using UnityEngine;
using System.Collections;

public class Falling_Script_Horizontal : MonoBehaviour {
	private GameObject fallingObject;
	public bool generateSpeed = false;
	public float movementSpeed = 0;
	private Vector3 movementAmount;
	// Use this for initialization
	void Start () {
		fallingObject = gameObject;
		if (generateSpeed)
			movementSpeed = Random.Range(.08f,.12f);
		movementAmount = new Vector3(movementSpeed,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		fallingObject.transform.position -= movementAmount * Time.deltaTime*100 * Initialize.slowTime;
	}
}
