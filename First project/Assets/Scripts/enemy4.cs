using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class enemy4 : MonoBehaviour

{
    public Transform[] points;
    private NavMeshAgent agent;
    private int destPoint = 0;

    private float myNoticeDistance = 5f;


    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.autoBraking = false;

        GoToPoint();

        print("hello world");
    }

    void GoToPoint()
    {
        if (points.Length == 0)
            return;

        agent.destination = points[destPoint].position;
        destPoint = (destPoint + 1) % points.Length;
    }

    void MoveToward(Vector3 position)
    {
        position = new Vector3(position.x, position.y, transform.position.z);
        
    }


    // Update is called once per frame
    void Update()
    {
        GameObject Player = GameObject.Find("Player");

        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GoToPoint();

    }

    private void FixedUpdate()
    {
        GameObject Player = GameObject.Find("Player");

        //if (Vector3.Distance(gameObject.transform, Player.transform.position) <= myNoticeDistance)
        //{
        //    MoveToward(Player.transform.position);
        //}
    }
}

    
