using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpener : MonoBehaviour
{
    [SerializeField]
    private Animator leftDoor, rightDoor;
    private string rightSlideAnim = "SlideRightanim" , LeftSlide  = "LeftSlide";
    private void OnTriggerEnter(Collider other)
    {
        print("yes");
        if(other.gameObject.CompareTag("Plane")){
            OpenDoors();
        }

    }
    private void OpenDoors(){
        leftDoor.Play(LeftSlide);
        rightDoor.Play(rightSlideAnim);

    }
    public void CloseDoors(){

    }

}
