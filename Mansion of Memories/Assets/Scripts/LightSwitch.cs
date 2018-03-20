﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LightSwitch : MonoBehaviour {
    AudioSource lightOnSound;
    AudioSource lightOffSound;

    public bool lighted;
    public bool playerActivated;

    public Light[] lights;
    private Light[] flickeringLights;
    private Light[] notFlickering;
    private Light[] delayedFlickering;
    private int fLights;
    private int nLights;
    private int dLights;

    private VRTK_InteractUse vrObj;



    private void Awake()
    {
        vrObj = GetComponent<VRTK_InteractUse>();
        AudioSource[] lightSounds = GetComponents<AudioSource>();
        lightOnSound = lightSounds[0];
        lightOffSound = lightSounds[1];

        flickeringLights = new Light[lights.Length];
        notFlickering = new Light[lights.Length];
        delayedFlickering = new Light[lights.Length];
        fLights = 0;
        nLights = 0;
        dLights = 0;
        for (int i = 0; i < lights.Length; i++)
        {
            lights[i].enabled = false;
            if (lights[i].gameObject.tag == "Flicker")
            {
                flickeringLights[fLights] = lights[i];
                fLights++;
            }
            else if (lights[i].gameObject.tag == "DelayedFlicker")
            {
                delayedFlickering[dLights] = lights[i];
                dLights++;
            }
            else
            {
                notFlickering[nLights] = lights[i];
                nLights++;
            }
        }
        lighted = false;
        playerActivated = false;
    }

    private void OnTriggerStay(Collider other)
    {
        if (this.vrObj.IsUseButtonPressed() == true)
        {
            lighted = !lighted;
            playerActivated = !playerActivated;
            for (int i = 0; i < dLights; i++)
            {
                if (delayedFlickering[i] != null)
                {
                    delayedFlickering[i].enabled = true;
                }

                if (lighted == false)
                {
                    if (delayedFlickering[i] != null)
                    {
                        delayedFlickering[i].enabled = false;
                    }
                }
            }
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
            for (int j = 0; j < notFlickering.Length; j++)
            {
                if (notFlickering[j] != null)
                {
                    notFlickering[j].enabled = true;
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

            for (int j = 0; j < notFlickering.Length; j++)
            {
                if (notFlickering[j] != null)
                {
                    notFlickering[j].enabled = false;
                }
            }
        }
    }
}
