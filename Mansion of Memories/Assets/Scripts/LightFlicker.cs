//Author: William Bennett
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: William Bennett

using UnityEngine;

public class LightFlicker : MonoBehaviour {

    [Header ("Set in the Inspector")]
    //Assign the light
    public Light lt;
    //Assign the audiosource
    public AudioSource fizzle;
    private bool player = false;

    private void Start()
    {
        lt = GetComponent<Light>();  
    }

    //Set player bool true when leaving area
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            player = true;
    }

    //Set player bool false when leaving area
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
            player = false;
    }

    private void Update()
    {
        if (player)
        {
            if (Random.value > 0.99)
            {
                if (lt.enabled != true)
                {
                    lt.enabled = true;
                    if (fizzle != null)
                    {
                        fizzle.Play();
                    }
                }
                else
                {
                    lt.enabled = false;
                }
            }
        }
    }

}
