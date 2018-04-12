//Author: Thomas Barrow
//Date Created: 4/1/18
//Date Modified: 4/1/18
//Modified by: Thomas Barrow

using System.Collections.Generic;
using UnityEngine;

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
