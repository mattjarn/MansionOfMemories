using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AssignObjects : MonoBehaviour
{
    public int numOfObjects;
    GameObject[] placements;
    List<GameObject> placementPoints = new List<GameObject>();
    public List<GameObject> objects;

    private void Awake()
    {

        placements = GameObject.FindGameObjectsWithTag("ObjectNeeded");
        for(int i=0; i<placements.Length;i++)
        {
            placementPoints.Add(placements[i]);
        }


        for (int j = 0; j < numOfObjects; j++)
        {
            int ind = Random.Range(0, placementPoints.Count);
            Vector3 position = new Vector3(placementPoints[ind].transform.position.x, placementPoints[ind].transform.position.y, placementPoints[ind].transform.position.z);

            int index = Random.Range(0, objects.Count);
            GameObject go = Instantiate(objects[index], position, placementPoints[ind].transform.rotation);
            go.tag = "Collectable";
            //go.AddComponent<Rigidbody>(); // Add the rigidbody.
            objects.RemoveAt(index);
            placementPoints.RemoveAt(ind);
        }


    }
}

