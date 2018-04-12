//Author: Thomas Barrow
//Date Created: 4/1/18
//Date Modified: 4/1/18
//Modified by: Thomas Barrow

using System.Collections.Generic;
using UnityEngine;

public class CollectibleTracker : MonoBehaviour
{
    private static List<GameObject> collectibles;
    [Header ("Set dymically")]
    //This needs to be read from the Menu to display
    public static int numberOfCollectiblesLeft;
    //Exposed method to grab the list of collectibles and put a copy here in the member variable, collectibles
    public static void Initialize(List<GameObject> collectiblesList)
    {
        collectibles = collectiblesList;
        if (collectibles != null)
        {
            numberOfCollectiblesLeft = collectibles.Count;
        }
    }

    //Exposed method to decrement the private member variable, numberOfCollectiblesLeft
    public static void RemoveCollectible()
    {
        numberOfCollectiblesLeft--;
    }

}
