using UnityEngine;
using System.Collections;

public class Player_Movement : MonoBehaviour {
	public float movementSpeed = 0;
	private Vector3 movementAmountX;
	private GameObject player;
	public float hoverAmount;
	public bool shouldHover = true;
	public float hoverLimits = 10f;

	// Use this for initialization
	void Start () {
		movementAmountX = new Vector3(movementSpeed, 0, 0);
		player = gameObject;
		StartCoroutine(Hover(hoverAmount));
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey("left") && player.transform.position.x >= 2.996f) {
			player.transform.position -= movementAmountX * Time.deltaTime*80;
		} else if (Input.GetKey("right") && player.transform.position.x <= 12.3f) {
			player.transform.position += movementAmountX * Time.deltaTime*80;
		}
	}

	void IEnumerator Hover(float hoverAmount) {
		while (shouldHover) {
			int dir = Random.Range(0,1);
			if (dir && ) { //Up
				player.transform.Translate(
		}
	}
}
