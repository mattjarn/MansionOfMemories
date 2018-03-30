using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AssignObjects : MonoBehaviour
{
    public GameObject[] placementPoints;
    public List<GameObject> objects;

    private void Awake()
    {

        placementPoints = GameObject.FindGameObjectsWithTag("ObjectNeeded");

        for (int i = 0; i < placementPoints.Length; i++)
        {
            Vector3 position = new Vector3(placementPoints[i].transform.position.x, placementPoints[i].transform.position.y, placementPoints[i].transform.position.z);
            int rotation = (int)(placementPoints[i].transform.eulerAngles.y / 90);

            int index = Random.Range(0, objects.Count);
            GameObject go = Instantiate(objects[index], position, placementPoints[i].transform.rotation);
            go.tag = "Collectable";
            go.AddComponent<Rigidbody>(); // Add the rigidbody.
            //gameObjectsRigidBody.mass = 5; // Set the GO's mass to 5 via the Rigidbody.
            objects.RemoveAt(index);
        }


    }
}

