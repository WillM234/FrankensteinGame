using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class push : MonoBehaviour
{
    bool continueMoving = false;
    float countDown;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.GetComponent<Rigidbody2D>().velocity = collision.gameObject.GetComponent<Rigidbody2D>().velocity;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        continueMoving = true;
        countDown = .5f;
    }
    private void Update()
    {
        if (continueMoving)
        {
            countDown -= Time.deltaTime;
            if (countDown <= 0.0f)
            {
                continueMoving = false;
                gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            }
        }
    }
}
