using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField, Range(1f, 5f)] private float speed = 0.2f;
    private float horizontal;
    private float vertical;

    void Awake()
    {
        Debug.Log("Awake");
    }

    void OnEnable()
    {
        Debug.Log("OnEnable");
    }

    void OnDisable()
    {
        Debug.Log("OnDisable");
    }

    void Start()
    {
        Debug.Log("Start");        
    }

    void Distroy()
    {
        Debug.Log("Distroy");
    }

    void Update()
    {
        GetInput();

        Move();        
    }

    void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void Move()
    {
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        transform.Translate(speed * changeInPosition * Time.deltaTime);
    }
}
