using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AiScript : MonoBehaviour
{
    public float speed = 5;
    bool movingRight = true;
    bool movingUp = true;

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        transform.Translate(Vector2.up * speed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Wall")
        {
            if(movingRight == true)
            {
                transform.eulerAngles = new Vector3(0, -180, 0);
                movingRight = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingRight = true;
            }
            
        }

        if(other.gameObject.tag == "Ceiling")
        {
            if (movingUp == true)
            {
                transform.eulerAngles = new Vector3(-180, 0, 0);
                movingUp = false;
            }
            else
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
                movingUp = true;
            }
        }

        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }
    }
}
