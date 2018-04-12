//Author: Matt Jarnevic
//Date Created: 3/18/18
//Date Modified: 3/28/18
//Modified by: Matt Jarnevic

using System.Collections.Generic;
using UnityEngine;

public class AssignRooms : MonoBehaviour
{
    private GameObject[] placementPoints;
    [Header ("Set in the Inspector")]
    //List of the rooms you want to be chosen from to spawn into the game.
    public List<GameObject> rooms;

    private void Awake()
    {
        placementPoints = GameObject.FindGameObjectsWithTag("Placeable");

        for(int i=0; i<placementPoints.Length;i++) {
            Vector3 position = new Vector3(placementPoints[i].transform.position.x, placementPoints[i].transform.position.y, placementPoints[i].transform.position.z);
            int rotation = (int)(placementPoints[i].transform.eulerAngles.y / 90);

            switch (rotation)
            {
                case 0:
                    position.x -= 2.25f;
                    position.y += 3.05f;
                    position.z -= 3.10f;
                    break;
                case 1:
                    position.x -= 3.10f;
                    position.y += 3.05f;
                    position.z += 2.25f;
                    break;
                case 2:
                    position.x += 2.25f;
                    position.y += 3.05f;
                    position.z += 3.10f;
                    break;
                case 3:
                    position.x += 3.10f;
                    position.y += 3.05f;
                    position.z -= 2.25f;
                    break;

            }

            int index = Random.Range(0, rooms.Count);
            Instantiate(rooms[index], position, placementPoints[i].transform.rotation);
            rooms.RemoveAt(index);
        }
    }
}

