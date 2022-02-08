using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStopper : MonoBehaviour
{
    public void CloseAnimator(){
      
        GetComponent<Animator>().Play("StayOpen");
    }
}
