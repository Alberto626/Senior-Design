using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApplyGravity : MonoBehaviour
{
    // Start is called before the first frame update
    /// <summary>
    //whenever this object collides with another, like an haybale hitting an apple, then gravity will start to work.
    /// </summary>
    /// 
    private Rigidbody rb;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision) // when hitting anything make sure gravity is applied
    {
        rb.useGravity = true;
    }
}
