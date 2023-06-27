// A script that will make the camera follow the player from above, looking down on them

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{

    public Transform player;
    private Vector3 playerOffset;

    private void Start() {
        transform.Rotate(90,0,0);
        // rotates the camera so it is facing the ground
        playerOffset = new Vector3 (0, player.transform.localScale.y, 0);
        // references the object it's following's height so that it can accurately move above them
        transform.position = player.transform.position + playerOffset + new Vector3 (0, 4, 0);  
        // the camera will move a height of 4 above the object its following
    }

    private void Update()
    {
        playerOffset.y = player.transform.localScale.y;
        transform.position = player.transform.position + playerOffset + new Vector3 (0, 4, 0);  
        // updates every frame
    }
}
