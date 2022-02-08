using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlaneLerpMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject checkpointParent;
    public static GameObject[] checkpoints;
    public static NavMeshAgent agent;
    public static int checkpointIndex;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
}
