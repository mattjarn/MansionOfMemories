using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelayedFlicker : MonoBehaviour {
    public Light lt;

    public AudioSource fizzle;

    public bool player;

    private void Start()
    {
        lt = GetComponent<Light>();  
    }

    private void OnTriggerStay(Collider other)
    { 
        if(other.gameObject.tag == "Player")
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

}
