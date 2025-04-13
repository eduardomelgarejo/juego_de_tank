using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Ai : MonoBehaviour
{
    public NavMeshAgent navMeshAgent; 
    public GameObject destino1; 
    public GameObject destino2; 
    public GameObject player; 

    private bool moviendoA2 = false; 
    private bool puedeMoverse = false; 

    void Start()
    {
        
        navMeshAgent.isStopped = true; 
    }

    void Update()
    {
        
        float distancia = Vector3.Distance(transform.position, player.transform.position);
        

        if (distancia <= 60f)
        {
            puedeMoverse = true; 
        }

        
        if (puedeMoverse)
        {
            
            navMeshAgent.isStopped = false;

            
            if (!navMeshAgent.pathPending && navMeshAgent.remainingDistance <= navMeshAgent.stoppingDistance)
            {
                
                if (moviendoA2)
                {
                    navMeshAgent.destination = destino1.transform.position;
                }
                else
                {
                    navMeshAgent.destination = destino2.transform.position; 
                }

                moviendoA2 = !moviendoA2; 
            }
        }
    }
}
