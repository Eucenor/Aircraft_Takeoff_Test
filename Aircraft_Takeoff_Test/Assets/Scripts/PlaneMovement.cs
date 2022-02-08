using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class PlaneMovement : MonoBehaviour
{
    [SerializeField]
    private GameObject checkpointParent;
    public static GameObject[] checkpoints;
    public static NavMeshAgent agent;
    public static int checkpointIndex;
    void Start()
    {
        checkpointIndex = 0;
        checkpoints = new GameObject[checkpointParent.transform.childCount];
        for(int i = 0; i < checkpoints.Length; i++){
            checkpoints[i] = checkpointParent.transform.GetChild(i).gameObject;
        }
        agent = GetComponent<NavMeshAgent>();
        agent.destination = checkpoints[checkpointIndex].transform.position;

    
    }

    // Update is called once per frame
    void Update()
    {

    }
}
