using UnityEngine;
using System.Collections;

public class Random_Spawning : MonoBehaviour {
	public GameObject portal, item,clock, asteroid, spacecop;
	public bool shouldSpawn;
	private float spawnPosition;

	// Use this for initialization
	void Start () {
		spawnPosition = -8f;
		StartCoroutine(ItemSpawn(Random.Range(0.01f, 1.2f)));
		StartCoroutine(AsteroidSpawn(Random.Range(0.01f, 1.2f)));
		StartCoroutine(PortalSpawn(Random.Range(8.0f, 15.0f)));
		StartCoroutine(SpacecopSpawn(Random.Range(3.0f, 5.0f)));
		StartCoroutine (ClockSpawn (Random.Range (8.0f, 15.0f)));
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("Fixed: " + Time.fixedDeltaTime);
	}

	public IEnumerator SpacecopSpawn (float waitTime) {
		while (shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(spacecop,new Vector2(Random.Range (2.996f,12.3f), spawnPosition), Quaternion.identity);
			yield return new WaitForSeconds(waitTime/4);
		}
	}

	public IEnumerator AsteroidSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(asteroid,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			/*
			for (int i = 0; i != Random.Range(1, 12); i++) {
				yield return new WaitForSeconds(waitTime);
				Instantiate(asteroid,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			}*/
			waitTime = Random.Range(0.04f, 1.0f);
		}
	}

	public IEnumerator ItemSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(item,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			waitTime = Random.Range(0.04f, 0.8f);
		}
	}

	public IEnumerator ClockSpawn (float waitTime) {
		while (shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(clock,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			waitTime = Random.Range(7.0f, 10.0f);
		}
	}

	public IEnumerator PortalSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(portal,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			waitTime = Random.Range(3.0f, 6.0f);
		}
	}
}