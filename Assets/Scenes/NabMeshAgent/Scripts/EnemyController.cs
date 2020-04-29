using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    private NavMeshAgent _agent;

    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        _agent = GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player").GetComponent<PlayerController>().transform;
    }

    // Update is called once per frame
    void Update()
    {
        _agent.SetDestination(player.position);
    }
}
