using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPush : MonoBehaviour
{
    bool moving = false;
    float countDown;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<Rigidbody2D>().velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        moving = true;
        countDown = .2f;
    }
    void Update()
    {
        if(moving)
        {
            countDown -= Time.deltaTime;
            if( countDown <= 0.0f)
            {
                moving = false;
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
    }
}
