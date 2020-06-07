using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiltControls : MonoBehaviour
{

    public float tiltSpeed = 1;
    public Vector3 startPos;

    private void Awake()
    {
        startPos = transform.position;
    }

    void FixedUpdate()
    {
        transform.Translate(Input.acceleration.x * tiltSpeed * Time.deltaTime, Input.acceleration.y * tiltSpeed * Time.deltaTime, 0);

        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.position = startPos;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "BlackHole")
        {
            transform.position = startPos;
        }
    }
}
