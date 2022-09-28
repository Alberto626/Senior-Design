using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepsSounds : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource audioSource;
    private CharacterController charactercontroller;
    private bool isPlaying;
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
        charactercontroller = gameObject.GetComponent<CharacterController>();
        isPlaying = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(charactercontroller.velocity == Vector3.zero) // not moving
        {
            audioSource.Stop();
            isPlaying = false;
        }
        else //if moving
        {
            if(isPlaying == false) //play this sound once 
            {
                audioSource.Play();
            }
            isPlaying = true;
        }
    }
}
