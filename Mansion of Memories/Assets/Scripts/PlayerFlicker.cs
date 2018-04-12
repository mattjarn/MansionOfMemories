//Author: William Bennett
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: William Bennett


using UnityEngine;

public class PlayerFlicker : MonoBehaviour {

    [Header("Set in the Inspector")]
    //The light switch
    public LightSwitch L;
    //The light associated with it
    public Light lt;
    //The audiosource to play
    public AudioSource fizzle;

    private void Start()
    {
        lt = GetComponent<Light>();  
    }

    private void OnTriggerStay(Collider other)
    {
        if (L.playerActivated)
        {
            if (Random.value > 0.9)
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

    private void OnTriggerExit(Collider other)
    {
        if(L.playerActivated)
            lt.enabled = true;
    }
}
