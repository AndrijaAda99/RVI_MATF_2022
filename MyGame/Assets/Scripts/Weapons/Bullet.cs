using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float speed;
    private int demage;

    public void Setup(int demage)
    {
        this.demage = demage;
        GetComponent<Rigidbody>().velocity = transform.forward * speed;
    }

    void OnCollisionEnter(Collision other)
    {
        if (other != null) {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
