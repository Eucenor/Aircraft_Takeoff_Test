using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointSetter : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        PlaneMovement.checkpointIndex++;
        PlaneMovement.agent.destination = PlaneMovement.checkpoints[PlaneMovement.checkpointIndex].transform.position;
        PlaneMovement.agent.speed += 300;
        GetComponent<BoxCollider>().enabled = false;
        print("done");
    }
}
