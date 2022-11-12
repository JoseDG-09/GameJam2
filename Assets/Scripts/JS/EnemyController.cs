using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyController : MonoBehaviour
{
    public Transform objective;
    public float speed = 5;
    public NavMeshAgent agent;
    private Animator animator;
    private float x, y = 0;
    public bool attack = true;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.speed = speed;
        agent.SetDestination(objective.position);
        if (agent.velocity == Vector3.zero && attack)
        {
            y = 0;
            x = 1;
        }
        else if (agent.velocity == Vector3.zero && !attack)
        {
            y = 0;
            x = 0;
        }
        else
        {
            y = 1;
            x = 0;
        }
        animator.SetFloat("speedY", y);
        animator.SetFloat("speedX", x);
    }
}
