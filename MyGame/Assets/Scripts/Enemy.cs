using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    public float moveSpeed = 1f;
    
    void Start()
    {
        navMeshAgent.speed = moveSpeed;
    }

    void Update()
    {
        MoveToPlayer();
    }
}
