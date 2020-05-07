using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{

    public float tiltSpeed = 1;

    void FixedUpdate()
    {
        transform.Translate(Input.acceleration.x * tiltSpeed * Time.deltaTime, Input.acceleration.y * tiltSpeed * Time.deltaTime, 0);
    }
}
