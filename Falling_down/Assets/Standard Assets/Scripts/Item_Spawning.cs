﻿using UnityEngine;
using System.Collections;

public class Item_Spawning : MonoBehaviour {
	public GameObject item;
	public bool shouldSpawn;
	private float spawnPosition;
	
	// Use this for initialization
	void Start () {
		spawnPosition = -8f;
		StartCoroutine(RandomSpawn(3.0f));
	}
	
	// Update is called once per frame
	void Update () {
	}
	
	public IEnumerator RandomSpawn (float waitTime) {
		while(shouldSpawn) {
			yield return new WaitForSeconds(waitTime);
			Instantiate(item,new Vector2(Random.Range(2.996f,12.3f),spawnPosition), Quaternion.identity);
		}
	}
}
