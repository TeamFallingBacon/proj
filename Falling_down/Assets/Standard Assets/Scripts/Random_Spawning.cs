using UnityEngine;
using System.Collections;

public class Random_Spawning : MonoBehaviour {
	public GameObject portal;
	private bool shouldSpawn;
	private float spawnPosition;

	// Use this for initialization
	void Start () {
		shouldSpawn = true;
		spawnPosition = -8f;
		StartCoroutine(RandomSpawn(3.0f));
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public IEnumerator RandomSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(portal,new Vector3(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
		}
	}
}
