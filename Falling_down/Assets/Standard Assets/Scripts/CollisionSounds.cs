﻿using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class CollisionSounds : MonoBehaviour {
	public AudioClip baconSound;
	public AudioClip asteroidSound;
	public AudioClip portalSound;
	public AudioClip spacecopSound;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnTriggerEnter2D(Collider2D other) {
		if (other.tag == "Asteroid") {
			audio.PlayOneShot(asteroidSound, .4f);
		} else if (other.tag == "Bacon") {
			audio.PlayOneShot(baconSound, 1f);
		} else if (other.tag == "Portal") {
			audio.PlayOneShot(portalSound);
		} else if (other.tag == "Spacecop") {
			audio.PlayOneShot(spacecopSound);
		}
	}
}
