using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiScript : MonoBehaviour
{
    public float speed = 2;
    public bool movingVertical = false;
    public bool movingHorizontal = false;

    bool movingRight = true;
    bool movingUp = true;

    void Update()
    {
        if (movingHorizontal)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        else if (movingVertical)
        {
            transform.Translate(Vector2.up * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (movingHorizontal)
        {
            if (other.gameObject.tag == "Wall")
            {
                if (movingRight == true)
                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                    movingRight = false;
                }
                else if (movingRight == false)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingRight = true;
                }
            }
        }

        if (movingVertical)
        {
            if (other.gameObject.tag == "Wall")
            {
                if (movingUp == true)
                {
                    transform.eulerAngles = new Vector3(0, 0, 180);
                    movingUp = false;
                }
                else if (movingUp == false)
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                    movingUp = true;
                }
            }
        }
    }
}
