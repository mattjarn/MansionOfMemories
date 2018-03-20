using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LightSwitch : MonoBehaviour {
    AudioSource lightOnSound;
    AudioSource lightOffSound;

    public bool lighted;

    public Light[] lights;
    private Light[] flickeringLights;
    private Light[] notFlickering;
    private int fLights;
    private int nLights;

    private VRTK_InteractUse vrObj;

  

    private void Awake()
    {
        vrObj = GetComponent<VRTK_InteractUse>();
        AudioSource[] lightSounds = GetComponents<AudioSource>();
        lightOnSound = lightSounds[0];
        lightOffSound = lightSounds[1];

        flickeringLights = new Light[lights.Length];
        notFlickering = new Light[lights.Length];
        fLights = 0;
        nLights = 0;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = false;
            if (lights[i].gameObject.tag == "Flicker")
            {
                flickeringLights[fLights] = lights[i];
                fLights++;
            }
            else
            {
                notFlickering[nLights] = lights[i];
                nLights++;
            }
        }
        lighted = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (this.vrObj.IsUseButtonPressed() == true)
        {
            lighted = !lighted;
        }
    }

    void Update()
    {
        if (lighted)
        {
            for (int i = 0; i < flickeringLights.Length; i++)
            {
                if (flickeringLights[i] != null)
                {
                    if (Random.value > 0.9)
                    {
                        if (flickeringLights[i].enabled != true)
                        {
                            flickeringLights[i].enabled = true;
                        }
                        else
                        {
                            flickeringLights[i].enabled = false;
                        }
                    }
                }
            }
        }
        else
        {
            for (int i = 0; i < flickeringLights.Length; i++)
            {
                if (flickeringLights[i] != null)
                {
                    flickeringLights[i].enabled = false;
                }
            }
        }
    }
}
