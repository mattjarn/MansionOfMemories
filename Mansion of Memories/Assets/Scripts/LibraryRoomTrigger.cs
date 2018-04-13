//Author: Matt Jarnevic
//Date Created: 4/12/18
//Date Modified: 
//Modified by:
using UnityEngine;
using UnityEngine.Playables;

public class LibraryRoomTrigger : MonoBehaviour
{
    [Header("Set in the Inspector")]
    //What timeline you want to trigger
    public PlayableDirector timeline;
    //The clip you want to play if you want sound
    public AudioSource clip;

    // Use this for initialization
    void Start()
    {
        timeline = GetComponent<PlayableDirector>();
    }

    //Stops timeline on player exit
    void OnTriggerExit(Collider c)
    {
        if (c.gameObject.tag == "SpecialBook")
        {
            timeline.Pause();
            clip.Pause();
        }
    }

    //Starts/resumes timeline when player enters. 
    void OnTriggerEnter(Collider c)
    {
        if (c.gameObject.tag == "SpecialBook")
        {
            timeline.Play();
            clip.Play();
        }

    }
}
