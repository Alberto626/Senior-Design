using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

[RequireComponent(typeof(ActionBasedController))]
public class LeftHandController : MonoBehaviour
{
    // Start is called before the first frame update
    ActionBasedController controller;
    public LeftHand LeftHand;
    void Start()
    {
        controller = GetComponent<ActionBasedController>();
    }

    // Update is called once per frame
    void Update()
    {
        LeftHand.SetGrip(controller.selectAction.action.ReadValue<float>());
        LeftHand.setTrigger(controller.activateAction.action.ReadValue<float>());
    }
}
