using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyPathfinding : MonoBehaviour
{
    public AIPath aiPath;

    void Start()
    {

    }


    void Update()
    {
        //set AI path to player
        aiPath.destination = GameObject.FindGameObjectWithTag("Player").transform.position;

    }
}
