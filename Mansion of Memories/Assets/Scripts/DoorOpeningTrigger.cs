//Author: Matt Jarnevic
//Date Created: 4/12/18
//Date Modified: 
//Modified by:
using UnityEngine;
using UnityEngine.Playables;

public class DoorOpeningTrigger : MonoBehaviour
{
    [Header("Set in the Inspector")]
    //What timeline you want to trigger
    public PlayableDirector timeline;
    //The clip you want to play if you want sound
    public AudioSource clip;

    private bool played = false;

    // Use this for initialization
    void Awake()
    {
        timeline = GetComponent<PlayableDirector>();
        clip = GetComponent<AudioSource>();
        played = false;
    }


    //Starts/resumes timeline when player enters. 
    void OnTriggerEnter(Collider c)
    {
        
        if((!played) && c.gameObject.tag == "Player")
        {
            print("#Triggered..." + played);
            timeline.Play();
            clip.Play();
            played = true;
        }
       

    }
}
