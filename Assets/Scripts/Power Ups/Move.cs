using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    [SerializeField] bool chasing;

    [SerializeField] NavMeshAgent agent;

    public Transform targetTransform;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (chasing)
        {
            agent.SetDestination(targetTransform.position);
        }

        else
        {
            transform.Translate(-transform.right * Time.deltaTime * 35, Space.World);
        }
    }
}
