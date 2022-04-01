using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : NPC
{
    public float moveSpeed = 1f;
    
    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        if (player == null) {
            Debug.LogError("Tag: 'Player' refernce nothing!");
        }
    }

    void Start()
    {
        navMeshAgent.speed = moveSpeed;
    }

    void Update()
    {
        MoveToPlayer();
    }
}
