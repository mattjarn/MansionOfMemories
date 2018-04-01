using UnityEngine;
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
        GetComponent<VRTK_BezierPointerRenderer>().enabled = !GetComponent<VRTK_BezierPointerRenderer>().enabled;
        GetComponent < VRTK_StraightPointerRenderer>().enabled = !GetComponent <VRTK_StraightPointerRenderer>().enabled;
        if (GetComponent<VRTK_StraightPointerRenderer>().enabled)
        {
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_StraightPointerRenderer>();
        } else
        {
            GetComponent<VRTK_Pointer>().pointerRenderer = GetComponent<VRTK_BezierPointerRenderer>();
        }
        menuState = !menuState;
        menu.SetActive(menuState);
    }
}
