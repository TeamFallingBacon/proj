using UnityEngine;
using System.Collections;

public class Background_Movement : MonoBehaviour {
	public GameObject debris;
	private float spawnPosition;
	public bool shouldSpawn;
	// Use this for initialization
	void Start () {
		spawnPosition = -8f;
		StartCoroutine(RandomSpawn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator RandomSpawn () {
		while(shouldSpawn) {
			float movementSpeed = Random.Range(.04f,.08f);
			yield return new WaitForSeconds(.4f);
			GameObject instance = (GameObject)Instantiate(debris,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
			Falling_Script fallScript = (Falling_Script)instance.GetComponent(typeof(Falling_Script));
			fallScript.movementSpeed = movementSpeed;
		}
	}
}
