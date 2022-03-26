using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerMovement : MonoBehaviour
{

    [SerializeField] Rigidbody rigidbody;
    [SerializeField] Camera cam;
    [SerializeField, Range(1f, 5f)] float speed = 0.2f;
    [SerializeField] Weapon weapon;

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
        Rotate();        

        if (Input.GetMouseButton(0))
        {
            if (weapon != null)
            {
                weapon.Shoot();
            }
        }
    }

    void Rotate()
    {
        RaycastHit hit;

        if (Physics.Raycast(cam.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity)) 
        {
            transform.LookAt(new Vector3(hit.point.x, transform.position.y, hit.point.z));
        }
    }

    void GetInput()
    {
        horizontal = Input.GetAxis("Horizontal");
        vertical = Input.GetAxis("Vertical");
    }

    void Move()
    {
        Vector3 changeInPosition = new Vector3(horizontal, 0f, vertical);
        Vector3 goToPosition = transform.position + changeInPosition * speed * Time.deltaTime;
        rigidbody.MovePosition(goToPosition);
    }
}
