using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed_Pick_up : MonoBehaviour
{
    public PlayerMovement P_Move;
    bool speedIncreased = false;
    public float countDown;
    public AudioSource A_Source;
    public AudioClip SpeedSound;
    private void Awake()
    {
    A_Source = GameObject.Find("Player").GetComponent<AudioSource>();
    P_Move = GameObject.Find("Player").GetComponent<PlayerMovement>();
    P_Move.speed = 20f;
    }
    private void Update()
    {
      if(speedIncreased)
        {
            countDown -= Time.deltaTime;
            P_Move.speed = 40f;
            if(countDown <= 0.0f)
            {
                speedIncreased = false;
                P_Move.speed = 20f;
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Speed_PickUp")
        {
            if (A_Source.isPlaying == false)
            {
                A_Source.PlayOneShot(SpeedSound);
            }
            speedIncreased = true;
            countDown = 5f;
        }
    }
}
