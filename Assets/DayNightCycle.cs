using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    // Start is called before the first frame update
    // Update is called once per frame
    private Color color1;
    private Color color2;
    public bool isNight;
    public Material NightSky;
    public Material MorningSky;
    public Material AfternoonSky;
    public Material SunsetSky;
    private void Start()
    {
        ColorUtility.TryParseHtmlString("#A4A4A4", out color1); // for the day
        ColorUtility.TryParseHtmlString("#222222", out color2); // for the night
        isNight = true;

    }
    void Update()
    {
        ChangeTime(); // night time
        if (transform.rotation.x < 0)
        {
            // changed starting time of day
            // RenderSettings.skybox = NightSky;
            RenderSettings.skybox = AfternoonSky;
            // changed bool
            // isNight = true;
            isNight = false;
            // commented fog off
            // ChangeFogDense();
        }
        if (transform.rotation.x > 0) // day time
        {
            if (transform.position.x < 3 && transform.position.x > 2) //morning sky
            {
                RenderSettings.skybox = MorningSky;
            }
            else if (transform.position.x < 2 && transform.position.x > -2)
            {
                RenderSettings.skybox = AfternoonSky;
            }
            else if (transform.position.x < -2 && transform.position.x > -3)
            {
                RenderSettings.skybox = SunsetSky;
            }
            isNight = false;
            ChangeFogLoose();
        }
    }
    public void ChangeTime()
    {
        // changed speed to slower rate
        // transform.RotateAround(Vector3.zero, Vector3.forward, 10f * Time.deltaTime);// speed should change later, default is 3f
        transform.RotateAround(Vector3.zero, Vector3.forward, 0.33f * Time.deltaTime);// speed should change later, default is 3f
        transform.LookAt(Vector3.zero);
    }
    public void ChangeFogDense() // for the night
    {
        RenderSettings.fogColor = color2;
        if (RenderSettings.fogDensity < 0.025f)
        {
            RenderSettings.fogDensity += 0.0002f;
        }
    }
    public void ChangeFogLoose() // for the day 
    {
        RenderSettings.fogColor = color1;
        if (RenderSettings.fogDensity > 0.0075f)
        {
            RenderSettings.fogDensity -= 0.0004f;
        }
    }

}
