using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CowTiming : MonoBehaviour
{
    // Start is called before the first frame update
    private AudioSource AudioSource;
    public int delayTiming;
    void Start()
    {
        AudioSource = gameObject.GetComponent<AudioSource>();
        AudioSource.PlayDelayed(delayTiming);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
