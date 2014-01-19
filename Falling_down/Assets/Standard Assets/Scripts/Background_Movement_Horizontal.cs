using UnityEngine;
using System.Collections;

public class Background_Movement_Horizontal : MonoBehaviour {
	public GameObject debris;
	private float spawnPosition;
	public bool shouldSpawn;
	// Use this for initialization
	void Start () {
		spawnPosition = 10f;
		StartCoroutine(RandomSpawn());
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	public IEnumerator RandomSpawn () {
		while(shouldSpawn) {
			float movementSpeed = Random.Range(.08f,.12f);
			yield return new WaitForSeconds(.25f);
			GameObject instance = (GameObject)Instantiate(debris,new Vector2(spawnPosition,Random.Range(-4.66f,4.66f)), Quaternion.Euler(0,0,90));
			Falling_Script_Horizontal fallScript = (Falling_Script_Horizontal)instance.GetComponent(typeof(Falling_Script_Horizontal));
			fallScript.movementSpeed = movementSpeed;
		}
	}
}
