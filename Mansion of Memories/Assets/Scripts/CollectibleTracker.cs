using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CollectibleTracker : MonoBehaviour
{
    private static List<GameObject> collectibles;
    public static int numberOfCollectiblesLeft; 
    public static void Initialize(List<GameObject> collectiblesList)
    {
        collectibles = collectiblesList;
        if (collectibles != null)
        {
            numberOfCollectiblesLeft = collectibles.Count;
        }
    }

    public static void RemoveCollectible()
    {
        numberOfCollectiblesLeft--;
    }

}
