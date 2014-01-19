using UnityEngine;
using System.Collections;

public class Random_Spawning_Horizontal : MonoBehaviour {
	public GameObject portal;
	public bool shouldSpawn;
	private float spawnPosition;
	// Use this for initialization
	void Start () {
		spawnPosition = 8f;
		StartCoroutine(RandomSpawn(3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public IEnumerator RandomSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(portal,new Vector2(spawnPosition,Random.Range(-4.66f,4.66f)), Quaternion.Euler(0,0,90));
		}
	}
}
