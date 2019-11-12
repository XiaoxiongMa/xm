using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]

public class AINav : MonoBehaviour
{
    private NavMeshAgent agent;
    public Vector3Data location;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = location.value;
    }
}

public class Vector3Data
{
    public Vector3 value;
}