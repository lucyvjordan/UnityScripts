// A script which when attached to a GameObject, will cause it to go backwards and forwards on a loop for a certain distance 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingObject : MonoBehaviour {

    private float direction = 1; // 1 represents forwards, and -1 represents backwards
    private float moveSpeed = 5;
    private float distanceMoved = 0;
    private float turnDistance = 24; // After moving 24, the object will start to go backwards
    
    void Update() {
    
        if (distanceMoved > turnDistance) {
            distanceMoved = 0;
            direction = direction * -1;
        }

        Vector3 distance = new Vector3(1, 0, 0) * Time.deltaTime * moveSpeed;
        // the object moves forward on the X axis
        distanceMoved += distance.x;
        transform.position += distance * direction;
        
    }
}
