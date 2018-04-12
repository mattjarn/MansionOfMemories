//Author: Unknown
//Date Created: Unkown
//Date Modified: 4/12/18
//Modified by: William Bennett
using UnityEngine;
using UnityEngine.Playables;

public class GenericTrigger : MonoBehaviour 
{
	public PlayableDirector timeline;

    private bool stopIt = false;

	// Use this for initialization
	void Start() 
	{
		timeline = GetComponent<PlayableDirector>();
	}
		

	void OnTriggerExit(Collider c)
	{
		if (c.gameObject.tag == "Player") 
		{
			timeline.Stop();
		}
	}

	void OnTriggerEnter(Collider c)
	{
        if (stopIt)
        {
            if (c.gameObject.tag == "Player")
            {
                stopIt = true;
                timeline.Play();
            }
        }
        else
            timeline.Resume();
	}
}