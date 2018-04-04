using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioSource sound;

	// Use this for initialization
	void Awake () {
        sound = GetComponent<AudioSource>();
	}

    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }
}
