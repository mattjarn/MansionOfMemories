using UnityEngine;
using UnityEngine.UI;

using VRTK;

public class MenuToggle : MonoBehaviour {
    public VRTK_ControllerEvents controllerEvents;
    public GameObject menu;

    bool menuState = false;

    private void OnEnable()
    {
        controllerEvents.ButtonTwoReleased += ControllerEvents_ButtonTwoReleased;
    }

    private void OnDisable()
    {
        controllerEvents.ButtonTwoReleased -= ControllerEvents_ButtonTwoReleased;
    }

    private void ControllerEvents_ButtonTwoReleased( object sender, ControllerInteractionEventArgs e)
    {
        if (GetComponent<VRTK_StraightPointerRenderer>().enabled)
        {
            GetComponent<VRTK_StraightPointerRenderer>().enabled = false;
            GetComponent<VRTK_BezierPointerRenderer>().enabled = true;
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_BezierPointerRenderer>();
        } else
        {
            GetComponent<VRTK_StraightPointerRenderer>().enabled = true;
            GetComponent<VRTK_BezierPointerRenderer>().enabled = false;
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_StraightPointerRenderer>();
        }
        menuState = !menuState;
        menu.SetActive(menuState);
        if (menu.activeInHierarchy)
        {
            GameObject.Find("CollectiblesLeft").GetComponent<Text>().text = "Number of Collectibles Left:   " + CollectibleTracker.numberOfCollectiblesLeft.ToString();
        }
    }
}
