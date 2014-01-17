using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
	public float movementSpeed = 0;
	private Vector3 movementAmountX;
	private GameObject player;
	// Use this for initialization
	void Start () {
		movementAmountX = new Vector3(movementSpeed, 0, 0);
		player = gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left")) {
			player.transform.position -= movementAmountX;
		} else if (Input.GetKey("right")) {
			player.transform.position += movementAmountX;
		}
	}
}
