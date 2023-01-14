using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class BalloonPhysics : MonoBehaviour
{
    public Rigidbody Rigidbody;
    public float Speed;
    public GameObject BoxBone;

    private void Start()
    {
        if (Rigidbody == null)
            Rigidbody = GetComponent<Rigidbody>();
        Rigidbody.useGravity = false;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Rigidbody.velocity = transform.up * Speed;
    }
}
