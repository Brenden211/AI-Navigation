using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ChasingScript : MonoBehaviour
{
    public Transform target;
    public float updateFrequency = 0.1f;

    private float updateCounter = 0;
    private NavMeshAgent agent;


    void Start()
    {
        agent = this.transform.GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        if (updateCounter >= updateFrequency)
        {
            agent.SetDestination(target.position);
            updateCounter = 0;
        }
        else
        {
            updateCounter += Time.deltaTime;
        }
    }
}
