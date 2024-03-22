using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    [SerializeField] private float walkAcc;
    [SerializeField] private float jumpAcc;


    private float mass;


    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        mass = rb.mass;
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.forward * WalkForceCalculate());
        }

        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.forward * WalkForceCalculate());
        }

        if (Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(transform.up * JumpForceCalculate());
        }
    }

    float WalkForceCalculate()
    {
        return mass * walkAcc;
    }

    float JumpForceCalculate()
    {
        return mass * jumpAcc;
    }
}
