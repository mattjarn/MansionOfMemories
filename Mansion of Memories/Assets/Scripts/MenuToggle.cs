//Author: Thomas Barrow
//Date Created: 4/4/18
//Date Modified: 4/4/18
//Modified by: Thomas Barrow

using UnityEngine;
using UnityEngine.UI;
using VRTK;

public class MenuToggle : MonoBehaviour
{
    [Header ("Set in the Inspector")]
    //The controller events to get when the buttons are pressed
    public VRTK_ControllerEvents controllerEvents;
    //Assign the menu item to modify based on buttons
    public GameObject menu;

    private bool menuState = false;

    //Register an event listener for the menu button
    private void OnEnable()
    {
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }

    //Deregister the event listener for the menu button
    private void OnDisable()
    {
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }

    //Swap the menu's active state when the menu button is released and change the pointer rendered between line and bezier curve
    private void ControllerEvents_ButtonTwoReleased(object sender, ControllerInteractionEventArgs e)
    {
        if (GetComponent<VRTK_StraightPointerRenderer>().enabled)
        {
            GetComponent<VRTK_StraightPointerRenderer>().enabled = false;
            GetComponent<VRTK_BezierPointerRenderer>().enabled = true;
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_BezierPointerRenderer>();
        }
        else
        {
            GetComponent<VRTK_StraightPointerRenderer>().enabled = true;
            GetComponent<VRTK_BezierPointerRenderer>().enabled = false;
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_StraightPointerRenderer>();
        }
        menuState = !menuState;
        menu.SetActive(menuState);
        if (menu.activeInHierarchy)
        {
            if (CollectibleTracker.numberOfCollectiblesLeft == 0)
            {
                GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "You've found all the items!";
            }
            else
            {
                GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "Number of Collectibles Left:   " + CollectibleTracker.numberOfCollectiblesLeft.ToString();
            }
        }
    }
}
