using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sceneChangeScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    private int tomatos;
    private int apples;
    private int haybales;
    private new NumberOfHayBales numberOfHayBales;
    private new NumberOfTomatoesInside numberOfTomatosInside;

    void Start()
    {

    }
    private void Awake()
    {
        numberOfHayBales = new NumberOfHayBales();
        numberOfTomatosInside = new NumberOfTomatoesInside();
        tomatos = 0;
        apples = 0;
        haybales = 0;
    }

    // Update is called once per frame
    void Update()
    {
        tomatos = numberOfTomatosInside.getNumberofTomatoes();
        apples = numberOfTomatosInside.getNumberOfApples();
        haybales = numberOfHayBales.getNumberOfHayBales();
        //Debug.Log(tomatos + " tomatos");
        //Debug.Log(apples + " apples");
        //Debug.Log(haybales + " haybales");
        //Test out if variables are working **they are**
        if(checkObjectives() == true)
        {
            //Scene Transition here
        }
    }
    public bool checkObjectives()
    {
        if(tomatos == 1 && apples == 1 && haybales == 1) //Change == later for real number of objectives
        {
            return true;
        }
        return false;

    }
}
