using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using System.Linq;

public class Particle : MonoBehaviour
{


    private InputDevice device;
    public ParticleSystem p1;
           

    // Start is called before the first frame update
    void Start()
    {

      List<InputDevice> devices = new List<InputDevice>();
      InputDeviceCharacteristics rightControllerCharacteristics = InputDeviceCharacteristics.Right;
      InputDevices.GetDevicesWithCharacteristics(rightControllerCharacteristics,devices);
      if(devices.Count > 0){
         device = devices[0];
      }
      
    }

    // Update is called once per frame
    void Update()
    {
        device.TryGetFeatureValue(CommonUsages.trigger,out float triggerValue);
        if(triggerValue > 0.1f){

           p1.Play();
        }
        else{
           p1.Stop();
        }
    }
}
