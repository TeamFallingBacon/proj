using UnityEngine;
using System.Collections;

public class Player_Movement_level3 : MonoBehaviour {

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
		movementAmountX = new Vector3(movementSpeed, 0, 0);
		movementAmountY = new Vector3(0,floatSpeed,0);
		player = gameObject;
		initialPosition = player.transform.position.y;
		StartCoroutine(Hover());
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log (player.transform.rotation);
		Debug.Log (player.transform.position);
		if (Input.GetKey("left") && player.transform.position.x >= 2.996f) {
			if (player.transform.rotation.z != 1.0f)
				player.transform.rotation = new Quaternion(0.0f,0.0f,1.0f,0.0f);
			player.transform.position -= movementAmountX * Time.deltaTime*80;
		} else if (Input.GetKey("right") && player.transform.position.x <= 12.3f) {
			if (player.transform.rotation.x != 1.0f)
				player.transform.rotation = new Quaternion(1.0f,0.0f,0.0f,0.0f);
			player.transform.position += movementAmountX * Time.deltaTime*80;
		}
	}
	
	public IEnumerator Hover() {
		while (shouldHover) {
			yield return new WaitForSeconds(0.05f);
			int dir = Random.Range(0,2);
			
			if (dir == 1 && (player.transform.position.y >= (initialPosition - hoverLimits))) { //Up
				moveAmount -= floatSpeed;
				player.transform.position -= movementAmountY*Time.deltaTime*30;
			} else if (dir == 0 && (player.transform.position.y <= (initialPosition + hoverLimits))) { //Down
				moveAmount += floatSpeed;
				player.transform.position += movementAmountY*Time.deltaTime*30;
			}
		}
	}
}