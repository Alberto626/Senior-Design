using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class burner : MonoBehaviour
{
    public bool burn;

    private void OnCollisionEnter(Collision collision) 
    {
         if (collision.gameObject.tag == "pan")
         {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.red);
            burn = true;
         }
    }

     private void OnCollisionExit(Collision collision)
     {
         if (collision.gameObject.tag == "pan")
         {
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
            burn = false;
         }
     }
}
