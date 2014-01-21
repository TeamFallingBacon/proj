using UnityEngine;
using System.Collections;

public class Item_Script : MonoBehaviour {
	private GameObject item;
	public float rotationSpeed;

	// Use this for initialization
	void Start () {
		item = gameObject;
		//StartCoroutine(Wiggle());
	}
	
	// Update is called once per frame
	void Update () {
	}
	/*
	public IEnumerator Wiggle() {
		float rotationAmount = 0;
		while (true) {
			yield return new WaitForSeconds(0.3f);
			item.transform.rotation = new Quaternion(0,0,rotationAmount,0);
			rotationAmount += rotationSpeed;
		}
//		while (true) {
//			yield return new WaitForSeconds(0);
//			do {
//				item.transform.rotation = new Quaternion(0,0,rotationAmount,0);
//				rotationAmount += rotationSpeed;
//			} while (Mathf.Abs(item.transform.rotation.z) <= 25);
//
//			if (item.transform.rotation.z < 25) {
//				while (item.transform.rotation.z >= 0) {
//					item.transform.rotation = new Quaternion(0,0,rotationAmount*Time.deltaTime,0);
//					rotationAmount += rotationSpeed;
//				}
//			} else if (item.transform.rotation.z < 25) {
//				while (item.transform.rotation.z <= 0) {
//					item.transform.rotation = new Quaternion(0,0,rotationAmount*Time.deltaTime,0);
//					rotationAmount -= rotationSpeed;
//				}
//			}
//		}
	}
	*/
	void OnTriggerEnter2D(Collider2D other) {
		if (item.tag == "Clock" && other.tag == "Player") {
			GameObject camera = GameObject.Find("Main Camera");
			ClockSlow slow = (ClockSlow) camera.GetComponent(typeof(ClockSlow));
			Debug.Log ("HitClock");
			slow.shouldSlow = true;
			Destroy(item);
		} else if (other.tag == "Player") {
			Destroy (item);
		}
	}


}
