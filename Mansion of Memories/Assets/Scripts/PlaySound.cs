using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySound : MonoBehaviour {

    public AudioSource sound;
    private void OnTriggerEnter(Collider other)
    {
        sound.Play();
    }

    //private void OnCollisionEnter(Collision collision)
    //{
    //        sound.Play();
    //}
}
