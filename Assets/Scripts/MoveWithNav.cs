using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveWithNav : MonoBehaviour
{
    public Transform target;
    NavMeshAgent navagent;

    void Start()
    {
        navagent = GetComponent<NavMeshAgent>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            navagent.SetDestination(target.position);
        }
    }
}
