using UnityEngine;
using System.Collections;

public class EnemySystem : MonoBehaviour {
	private GameObject enemy;
	private Vector3 movementAmount;
	private Vector3 initialPosition;
	public float movementSpeed;
	// Use this for initialization
	void Start () {
		enemy = gameObject;
		initialPosition = enemy.transform.position;
		movementAmount = new Vector3(0,movementSpeed,0);
		//Phase one, move up
		StartCoroutine(MoveToScreen());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator MoveToScreen() {
		while(true) {
			yield return new WaitForSeconds(0);
			enemy.transform.position += movementAmount * Time.deltaTime*40;
			if ((enemy.transform.position.y - initialPosition.y) >= 2.3) {
				break;
			}
		}
		//Phase two, follow player
		StartCoroutine(FollowPlayer());
	}

	public IEnumerator FollowPlayer() {
		float timer = 4;
		GameObject player = GameObject.Find("Player");
		float xOffset = 0;
		while(timer > 0) {
			timer -= Time.deltaTime;
			Debug.Log ("TIMER: " + timer);
			yield return new WaitForSeconds(0);
			enemy.transform.position = Vector3.MoveTowards(enemy.transform.position, new Vector3(player.transform.position.x, enemy.transform.position.y, enemy.transform.position.z), 3.7f*Time.deltaTime);
		}
		//Phase three, shoot toward player
		StartCoroutine(ShootTowards());
	}

	public IEnumerator ShootTowards() {
		while(true) {
			yield return new WaitForSeconds(0);
			enemy.transform.position += movementAmount * Time.deltaTime*125;
		}
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Player") {
			Destroy (enemy);
		}
	}
}
