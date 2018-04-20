//Author: Matt Jarnevic
//Date Created: 4/20/18
//Date Modified: 
//Modified by:
using UnityEngine;
using UnityEngine.Playables;

public class DoorKnockingTrigger : MonoBehaviour
{
    [Header("Set in the Inspector")]
    //The clip you want to play if you want sound
    public AudioSource clip;

    private bool played = false;

    // Use this for initialization
    void Awake()
    {
        clip = GetComponent<AudioSource>();
        played = false;
    }


    //Starts/resumes timeline when player enters. 
    void OnTriggerEnter(Collider c)
    {
        
        if((!played) && c.gameObject.tag == "Player")
        {
            clip.Play();
            played = true;
        }
       

    }
}
