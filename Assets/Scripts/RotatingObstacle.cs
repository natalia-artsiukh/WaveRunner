using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingObstacle : MonoBehaviour
{
    
    void Update()
    {
        transform.Rotate(new Vector3(transform.rotation.x, transform.rotation.y, 45) * Time.deltaTime, Space.Self);
    }
}
