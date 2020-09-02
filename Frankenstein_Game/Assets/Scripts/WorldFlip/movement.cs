using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    float speed = 2;
    public Rigidbody2D rb;

    public GameObject cam1;
    public GameObject cam2;


    // Update is called once per frame
    void Update()
    {


        if (rb.velocity.y < 1)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                rb.gravityScale = rb.gravityScale * -1;


            }
        }

        if (rb.gravityScale == 1)
        {
            cam1.SetActive(true);
            cam2.SetActive(false);
        }
        else
        {
            cam1.SetActive(false);
            cam2.SetActive(true);
        }
      rb.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * speed * rb.gravityScale, rb.velocity.y);
      
    }
    
}

