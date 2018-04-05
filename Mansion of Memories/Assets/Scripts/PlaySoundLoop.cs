using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySoundLoop : MonoBehaviour {

    public AudioSource sound;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.loop = true;
            sound.Play();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        sound.Stop();
    }
}
