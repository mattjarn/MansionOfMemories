using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;



public class RoomAssigner : MonoBehaviour
{
    public int numberOfRooms;
    public float houseWidth;
    public float houseLength;
    public GameObject[] roomList;

   
    // Use this for initialization
    void Start()
    {
        int roomCount = 0;
        Vector3 startingPos = new Vector3(0, 0, 0);
        if (houseWidth % 2 == 0&&houseLength%2==0)
        {
            startingPos = new Vector3(-10 * houseWidth/2 + 5, 0, 10 *houseLength/2 - 5);
        }
        if (houseWidth % 2 != 0 && houseLength % 2 != 0)
        {
            startingPos = new Vector3(-10 * houseWidth / 2 + 5f, 0, 10 * houseLength / 2 - 5f);
        }

        roomList = GameObject.FindGameObjectsWithTag("Room");
        //These two lines set up an array of ints ranging from 0 to the numberOfRooms we have (set in the inspector).  We use these values to randomize the indexing of our rooms
        //so each time it is played the rooms are randomly assigned to spots.  
        System.Random rnd = new System.Random();
        int[] numbers = Enumerable.Range(0, numberOfRooms).OrderBy(r => rnd.Next()).ToArray();
        
        if (roomList.Length != 0)
        {
            for (int row = 0; row < houseWidth; row++)
            {
                if (roomCount >= numberOfRooms)
                {
                    break;
                }
                for (int col = 0; col < houseLength; col++)
                {
                    if (roomCount >= numberOfRooms)
                    {
                        break;
                    }
                    
                    roomList[numbers[roomCount]].transform.position = startingPos + new Vector3(col * 10, 0, -row * 10);
                    roomCount++;
                }
            }
        }

        //Destroy all other rooms left over in the roomList which we aren't using.  
    }

    // Update is called once per frame
    void Update()
    {

    }
}
