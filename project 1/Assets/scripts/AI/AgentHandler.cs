using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


[RequireComponent(typeof(NavMeshAgent))]

public class AgentHandler : MonoBehaviour
{
    private NavMeshAgent agent;
    private Vector3 currentDestination;
    private Vector3 startpoint;
    public Transform destinationObj;
    void Start()
    {
        
        startpoint= transform.position;
        currentDestination = startpoint;
        agent = GetComponent<NavMeshAgent>();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        currentDestination = destinationObj . position;
    }

    private void OnTriggerExit(Collider other)
    {
        currentDestination = startpoint;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = currentDestination;
    }
}
