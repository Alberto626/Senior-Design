using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfHayBales : MonoBehaviour
{
    // Start is called before the first frame update
    //yes this does work
    public static int numberOfHayBales;
    void Start()
    {
        
    }
    private void Awake()
    {
        numberOfHayBales = 0;
    }

    // Update is called once per frame
    void Update() // yes this does work
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "HayBales")
        {
            numberOfHayBales++;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if(collision.gameObject.tag == "HayBales")
        {
            numberOfHayBales--;
        }
    }
    public int getNumberOfHayBales()
    {
        return numberOfHayBales;
    }
}
