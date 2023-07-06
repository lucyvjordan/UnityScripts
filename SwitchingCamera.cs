using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchingCamera : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private GameObject cameras;

    void LateUpdate()
    {
        if (player.name == "Player1" && Input.GetKeyDown("e")) {
            SwitchCamera();
        }
        if (player.name == "Player2" && Input.GetKeyDown("right ctrl")) {
            SwitchCamera();
        }        
        // works for split screen games where there are multiple cameras
    }

    void SwitchCamera() {

        int cameraIndex = transform.GetSiblingIndex();
        //  gets the index of the current child camera in the group

        cameras.transform.GetChild(cameraIndex).gameObject.SetActive(false);
        // sets the current camera to inactive

        cameraIndex += 1;
        // increases the index by 1 to reference the next camera in the group

        if (cameraIndex > cameras.transform.childCount - 1) {
            cameraIndex = 0;
            // if the index is now greater than the number of cameras available, loop back to the first camera in the group
        }

        cameras.transform.GetChild(cameraIndex).gameObject.SetActive(true);
        // set the new camera to active

    }
}
