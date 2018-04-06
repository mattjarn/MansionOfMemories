using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleTracker : MonoBehaviour
{
    private static List<GameObject> collectibles;
    private static int totalNumberOfCollectibles;
    public static int numberOfCollectiblesLeft; 
    public static void Initialize(List<GameObject> collectiblesList)
    {
        collectibles = collectiblesList;
        if (collectibles != null)
        {
            totalNumberOfCollectibles = collectibles.Count;
            numberOfCollectiblesLeft = totalNumberOfCollectibles;
            print(numberOfCollectiblesLeft);
            print(totalNumberOfCollectibles);
        }
        GameObject.Find("TotalCollectibles").GetComponent<Text>().text = "Number of Total Collectibles:   " + totalNumberOfCollectibles.ToString();
        GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "Number of Collectibles Left:   " + numberOfCollectiblesLeft.ToString();
    }

    public static void RemoveCollectible()
    {
        numberOfCollectiblesLeft--;
    }

}
