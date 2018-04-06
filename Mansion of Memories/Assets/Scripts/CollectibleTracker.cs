using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleTracker : MonoBehaviour
{
    private static List<GameObject> collectibles;
    private static int totalNumberOfCollectibles;
    public static int numberOfCollectiblesLeft;

    private void Awake()
    {
        collectibles = AssignObjects.collectableObjects;
        if (collectibles != null)
        {
            totalNumberOfCollectibles = collectibles.Count;
            numberOfCollectiblesLeft = totalNumberOfCollectibles;
        }
        GameObject.Find("TotalCollectibles").GetComponent<Text>().text = "Number of Total Collectibles:   " + totalNumberOfCollectibles.ToString();
        GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "Number of Collectibles Left:   " + numberOfCollectiblesLeft.ToString();
    }

    public static void RemoveCollectible(GameObject collectible)
    {
        collectibles.Remove(collectible);
        numberOfCollectiblesLeft--;
        GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "Number of Total Collectibles:   " + numberOfCollectiblesLeft.ToString();
    }

}
