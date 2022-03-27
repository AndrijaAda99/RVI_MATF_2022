using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NPC : BaseCharacter
{
    public GameObject player;
    public NavMeshAgent navMeshAgent;
   
    public void MoveToPlayer() 
    {
        if (player != null && navMeshAgent.isOnNavMesh) 
        {
            navMeshAgent.SetDestination(player.transform.position);
        }
    }

    void Start()
    {

    }

   
    void Update()
    {
        
    }
}
