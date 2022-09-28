using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class windMillRotation : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform GameObject;
    void Start()
    {
        GameObject = this.gameObject.transform;
    }

    // Update is called once per frame
    void Update()
    {

        float moveSpeed = 0.005f;
        GameObject.Rotate(0,0,moveSpeed);        
    }
}
