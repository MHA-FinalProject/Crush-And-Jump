using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMover : MonoBehaviour
{
    public float moveSpeed;
    public float deadZone;

    
    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        

        // Check if the object crossed the deadZone
        if (transform.position.x < deadZone)
        {
            Destroy(gameObject);
        }
    }
}
