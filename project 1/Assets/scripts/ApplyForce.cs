using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class ApplyForce : MonoBehaviour
{
    private Rigidbody rb;
    public Vector3Data forcesDirection;
    public float force = 3f;
    
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void OnCollisionEnter(Collision other)
    {
        rb.AddForce(forcesDirection.value*force);
    }
}
