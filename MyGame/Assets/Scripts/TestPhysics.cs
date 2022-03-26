using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TestPhysics : MonoBehaviour
{
    [SerializeField] Rigidbody rigidbody;
    [SerializeField] MeshRenderer meshRenderer;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.J)) 
        {
            rigidbody.AddForce(Vector3.up * 100, ForceMode.Force);
        }
        if (Input.GetKeyUp(KeyCode.K)) 
        {
            rigidbody.AddForce(Vector3.up * 4, ForceMode.Impulse);
        }
        if (Input.GetKeyUp(KeyCode.L))
        {
            rigidbody.AddForce(Vector3.up * 10, ForceMode.VelocityChange);
        }
    }

    void OnTriggerEnter(Collider other) 
    {
        meshRenderer.material.color = Color.red;
    }

    void OnTriggerExit(Collider other)
    {
        meshRenderer.material.color = Color.white;

    }

    void OnCollisionEnter(Collision other)
    {
        meshRenderer.material.color = Color.blue;
    }
    
}
