using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AssignRooms : MonoBehaviour
{
    public int numberOfRooms;
    public GameObject[] roomList;
    public GameObject[] placementPoints;
    public GameObject roomPrefab;

    private void Awake()
    {

        //roomList = GameObject.FindGameObjectsWithTag("Room");
        placementPoints = GameObject.FindGameObjectsWithTag("Placeable");

        //Instantiate(library[Random.Range(0, library.Length)], new Vector3(x, y, z), Quaternion.identity);

        //GameObject room = Instantiate<GameObject>(roomPrefab);

        //room.transform.position = placementPoints[0].transform.position;

        for(int i=0; i<placementPoints.Length;i++) {
            Vector3 position = new Vector3(placementPoints[i].transform.position.x, placementPoints[i].transform.position.y, placementPoints[i].transform.position.z);
            int rotation = (int)(placementPoints[i].transform.eulerAngles.y / 90);
            print(position);
            print(rotation);

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

            Instantiate(roomList[Random.Range(0, roomList.Length)], position, placementPoints[i].transform.rotation);
        }
        

    }
}

