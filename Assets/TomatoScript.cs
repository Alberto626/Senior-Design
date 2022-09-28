using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoScript : MonoBehaviour
{
    // Start is called before the first frame update
    bool beenGrabbed;
    void Start()
    {
        beenGrabbed = false; // object has never been grabbed before
    }

    // Update is called once per frame
    void Update()
    {
        //find a way find a way that object has been grabbed
        if(beenGrabbed == true) // if the object has been grabbed by player, then gravity should is not applied to object
        {
            //gravity hits
            // change rigid body use Gravity to true
        }
    }
}
