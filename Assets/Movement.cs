using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float explosionForce = 10;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        // GetComponent<Rigidbody>().AddExplosionForce(explosionForce, new Vector3(100,20,30), 1000);
        rb = GetComponent<Rigidbody>();
        
    }

    void FixedUpdate()
    {
        if (Input.GetAxis("Jump") > 0)
        {
            rb.AddForce(100, 0, 0);
            rb.AddTorque(30, 20,30);
        }
    }
}
