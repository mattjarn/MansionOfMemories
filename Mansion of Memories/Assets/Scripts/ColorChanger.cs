using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour {
    System.Random rnd = new System.Random();
    int slowDown = 0;
    // Use this for initialization
    void Start () {
       
    }
	
	// Update is called once per frame
	void Update () {
        if (slowDown > 30)
        {
            Renderer rend = GetComponent<Renderer>();
            rend.material.shader = Shader.Find("Specular");
            rend.material.color = new Color(rnd.Next() * 255, rnd.Next() * 255, rnd.Next() * 255);
            slowDown = 0;
        }
        slowDown++;
    }
}
