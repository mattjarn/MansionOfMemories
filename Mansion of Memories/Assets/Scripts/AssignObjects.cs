//Author: Matt Jarnevic
//Date Created: 3/22/18
//Date Modified: 4/4/18
//Modified by: Matt Jarnevic

using System.Collections.Generic;
using UnityEngine;

public class AssignObjects : MonoBehaviour
{
    [Header("Set in Inspector")]
    //The total number of interactable objects to instantiate into the scene.
    public int numOfObjects;
    //The list of objects to be placed.
    public List<GameObject> objects;

    private GameObject[] placements;
    private List<GameObject> placementPoints = new List<GameObject>();
    static private List<GameObject> collectableObjects;

    private void Start()
    {
        collectableObjects = objects;
        CollectibleTracker.Initialize(collectableObjects);
        placements = GameObject.FindGameObjectsWithTag("ObjectNeeded");
        
        for(int i=0; i<placements.Length;i++)
        {
            placementPoints.Add(placements[i]);
        }

        for (int j = 0; j < numOfObjects; j++)
        {
            print(j);
            int ind = Random.Range(0, placementPoints.Count);
            Vector3 position = new Vector3(placementPoints[ind].transform.position.x, placementPoints[ind].transform.position.y, placementPoints[ind].transform.position.z);

            int index = Random.Range(0, objects.Count);
            GameObject go = Instantiate(objects[index], position, placementPoints[ind].transform.rotation);
            go.tag = "Collectable";
            objects.RemoveAt(index);
            placementPoints.RemoveAt(ind);
        }


    }
}

