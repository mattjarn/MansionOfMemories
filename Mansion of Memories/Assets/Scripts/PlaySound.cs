//Author: William Bennett
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: William Bennett

using UnityEngine;

public class PlaySound : MonoBehaviour {

    [Header("Set in the Inspector")]
    //Audiosource to play
    public AudioSource sound;

    //Plays the sound once if the player enters the area
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
            sound.Play();
    }
}
