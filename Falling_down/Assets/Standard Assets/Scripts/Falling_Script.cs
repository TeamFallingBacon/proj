using UnityEngine;
using System.Collections;

public class Falling_Script : MonoBehaviour {
	private GameObject portal;
	public float movementSpeed = 0;
	private Vector3 movementAmount;
	// Use this for initialization
	void Start () {
		portal = gameObject;
		movementAmount = new Vector3(0,movementSpeed,0);
	}
	
	// Update is called once per frame
	void Update () {
		portal.transform.position += movementAmount;
	}
}
