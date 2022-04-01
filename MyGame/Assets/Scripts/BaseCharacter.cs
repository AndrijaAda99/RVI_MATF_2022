using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCharacter : MonoBehaviour, IDamagable
{
    [SerializeField] int health;

    public int Health() { get: { return health; } }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0) {
            Die();
        }
    }
    public void Die()
    {
        Destroy(gameObject);
    }
    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
