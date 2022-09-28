using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class WristMenu : MonoBehaviour
{

    public GameObject wristUI;
    public bool isActiveWristUI = true;

    void Start()
    {
        DisplayWristUI();
    }

    public void MenuPressed(InputAction.CallbackContext context)
    {
        if(context.performed)
            {
                DisplayWristUI();
            }
    }

    public void DisplayWristUI()
    {
        isActiveWristUI = !isActiveWristUI;
        wristUI.SetActive(isActiveWristUI);
    }
}
