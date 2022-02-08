using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitcher : MonoBehaviour
{
    [SerializeField]
    private GameObject cameraPoint, mainCamera;
    private GameObject[] cameraPoints;
    private int index = 0;
    void Start()
    {
        cameraPoints = new GameObject[cameraPoint.transform.childCount];
        for (int i = 0; i < cameraPoint.transform.childCount; i++){
            cameraPoints[i] = cameraPoint.transform.GetChild(i).gameObject;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C)){
            index = (index + 1) % cameraPoints.Length;
            mainCamera.transform.position = cameraPoints[index].transform.position;
            mainCamera.transform.rotation = cameraPoints[index].transform.rotation;
        }
    }
}
