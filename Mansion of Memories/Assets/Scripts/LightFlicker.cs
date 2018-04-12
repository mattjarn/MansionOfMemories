//Author: William Bennett
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: William Bennett

using UnityEngine;

public class LightFlicker : MonoBehaviour {

    public Light lt;

    public AudioSource fizzle;

    public bool player = false;

    private void Start()
    {
        lt = GetComponent<Light>();  
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Player")
            player = true;
    }

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
