//Author: William Bennett
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: William Bennett

using UnityEngine;

public class PlaySoundLoop : MonoBehaviour {
    [Header("Set in the Inspector")]
    //Audiosource
    public AudioSource sound;

    //Plays the sound on loop while the player is in the area.
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            sound.loop = true;
            sound.Play();
        }
    }

    //Stops the sound when leaving the area
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            sound.Stop();
    }
}
