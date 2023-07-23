using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    
    private Vector3 spawnPos;
    private float repeatWidth;
    

    void Start()
    {
        spawnPos = transform.position;
        // the background will reset to the start position
        repeatWidth = GetComponent<SpriteRenderer>().bounds.size.x / 2;
        // gets the width of the background / 2
        // the background is repeated twice, so when the second half takes the place of the first half, it will reset to the start pos
    }

    void Update()
    {
        if (transform.position.x < spawnPos.x - repeatWidth) {
            // spawn pos is measured from the middle of the background
            // so if the background has moved half the length of the background, it will reset  
            transform.position = spawnPos;
        }
    }
}
