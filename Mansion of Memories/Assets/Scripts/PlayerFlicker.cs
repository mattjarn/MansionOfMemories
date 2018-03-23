using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFlicker : MonoBehaviour {
    public LightSwitch L;

    public Light lt;

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
