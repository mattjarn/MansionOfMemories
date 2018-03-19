using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickerLights : MonoBehaviour {

    public Light lightObject;


	// Use this for initialization
	void Start () {
        lightObject = GetComponent<Light>();
	}

	void Update () {
            if (Random.value > 0.9)
            {
                if (lightObject.enabled == true)
                {
                    lightObject.enabled = false;
                }
                else
                    lightObject.enabled = true;
            }
	}
}
