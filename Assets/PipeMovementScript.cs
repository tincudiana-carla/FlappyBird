using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeMovementScript : MonoBehaviour
{
    public float moveSpeed = 0.025f;
    public float deadZone = -10.04f;
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.position = transform.position + (Vector3.left * moveSpeed) * Time.deltaTime;
        if (transform.position.x < deadZone)
            Destroy(gameObject);
    }
}
