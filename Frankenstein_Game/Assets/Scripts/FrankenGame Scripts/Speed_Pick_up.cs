using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Pick_up : MonoBehaviour
{
    public PlayerMovement P_Move;
    bool speedIncreased = false;
    float countDown;
    private void Awake()
    {
    P_Move = GameObject.Find("Player").GetComponent<PlayerMovement>();
    P_Move.speed = 10f;
    }
    private void Update()
    {
      if(speedIncreased)
        {
            countDown -= Time.deltaTime;
            P_Move.speed = 20f;
            if(countDown <= 0.0f)
            {
                speedIncreased = false;
                P_Move.speed = 10f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        speedIncreased = true;
        countDown = 5f;
    }
}
