using UnityEngine;
using System.Collections;

public class Random_Spawning : MonoBehaviour {
	public GameObject portal, item, asteroid, spacecop;
	public bool shouldSpawn;
	private float spawnPosition;

	// Use this for initialization
	void Start () {
		spawnPosition = -8f;
		StartCoroutine(ItemSpawn(Random.Range(0.01f, 1.2f)));
		StartCoroutine(AsteroidSpawn(Random.Range(0.01f, 1.2f)));
		StartCoroutine(PortalSpawn(Random.Range(3.0f, 6.0f)));
		StartCoroutine(SpacecopSpawn(Random.Range(5.0f, 8.0f)));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator SpacecopSpawn (float waitTime) {
		while (shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(spacecop,new Vector2(Random.Range (2.996f,12.3f), spawnPosition), Quaternion.identity);
			yield return new WaitForSeconds(waitTime/3);
		}
	}

	public IEnumerator AsteroidSpawn (float waitTime) {
		while(shouldSpawn) {
			for (int i = 0; i != Random.Range(1, 12); i++) {
				yield return new WaitForSeconds(waitTime);
				Instantiate(asteroid,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			}
			waitTime = Random.Range(0.01f, 2.0f);
		}
	}

	public IEnumerator ItemSpawn (float waitTime) {
		while(shouldSpawn) {
			for (int i = 0; i != Random.Range(6, 9); i++) {
				yield return new WaitForSeconds(waitTime);
				Instantiate(item,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			}
			waitTime = Random.Range(0.04f, 2.0f);
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