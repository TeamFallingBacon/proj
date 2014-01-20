using UnityEngine;
using System.Collections;

public class Player_Moment_Horizontal : MonoBehaviour {
	public float movementSpeed = 0;
	public float floatSpeed = 0;
	private Vector3 movementAmountX;
	private Vector3 movementAmountY;
	private float initialPosition;
	private GameObject player;
	public bool shouldHover = true;
	public float hoverLimits;
	private float moveAmount = 0;

	// Use this for initialization
	void Start () {
		movementAmountX = new Vector3(floatSpeed,0,0);
		movementAmountY = new Vector3(0, movementSpeed, 0);
		player = gameObject;
		initialPosition = player.transform.position.x;
		//StartCoroutine(Hover());
	}

	// Update is called once per frame
	void Update () {
		//Debug.Log (player.transform.rotation.x);
		Debug.Log (player.transform.rotation);
		Debug.Log (new Quaternion (0,180*Time.timeScale,270*Time.timeScale,0));
		if (Input.GetKey("down") && player.transform.position.y >= -4.35f) {
			if (player.transform.rotation.x != 0.7f)
				player.transform.rotation = new Quaternion(0.7f*Time.deltaTime,-0.7f*Time.deltaTime,0.0f,0.0f);
			player.transform.position -= movementAmountY * Time.deltaTime*80;
		} else if (Input.GetKey("up") && player.transform.position.y <= 3.9f) {
			if (player.transform.rotation.z != 0.7f)
				player.transform.rotation = new Quaternion(0.0f,0.0f,0.7f*Time.deltaTime,0.7f*Time.deltaTime);
			player.transform.position += movementAmountY * Time.deltaTime*80;
		}
	}

	public IEnumerator Hover() {
		while (shouldHover) {
			yield return new WaitForSeconds(0.05f);
			int dir = Random.Range(0,2);
			Debug.Log(player.transform.position.x);
			Debug.Log (initialPosition);
			Debug.Log (dir);
			if (dir == 1 && (player.transform.position.x >= (initialPosition - hoverLimits))) { //left
				moveAmount -= floatSpeed;
				player.transform.position -= movementAmountX*Time.deltaTime*20;
			} else if (dir == 0 && (player.transform.position.x <= (initialPosition + hoverLimits))) { //right
				moveAmount += floatSpeed;
				player.transform.position += movementAmountX*Time.deltaTime*20;
			}
		} 
	}
}
