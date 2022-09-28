using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumberOfTomatoesInside : MonoBehaviour
{
    // Start is called before the first frame update
    // Change this script for later, as this will include a objective that will determine the scene transition
    public static int numberOfTomatoes;
    public static int numberofApples;
    void Start()
    {

    }
    private void Awake()
    {
        numberOfTomatoes = 0;
        numberofApples = 0;
    }
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(numberofApples + " apples");
        //Debug.Log(numberOfTomatoes + " tomatoes");
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Tomato")
        {
            numberOfTomatoes++;
        }
        if(collision.gameObject.tag == "Apple")
        {
            numberofApples++;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.tag == "Tomato")
        {
            numberOfTomatoes--;
        }
        if (collision.gameObject.tag == "Apple")
        {
           numberofApples--;
        }
    }
    public int getNumberofTomatoes()
    {
        return numberOfTomatoes;
    }
    public int getNumberOfApples()
    {
        return numberofApples;
    }
}
