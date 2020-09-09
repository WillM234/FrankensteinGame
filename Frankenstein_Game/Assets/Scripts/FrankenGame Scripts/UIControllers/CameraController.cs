using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    private GameObject PlayerParent;//player reference
    private Vector3 offset;// stores offset between player object and camera
    private void Awake()
    {
        PlayerParent = GameObject.Find("Player");
        offset = transform.position - PlayerParent.transform.position;
        //calculates and stores offset value. obtains position distance between the player and camera
    }
    private void LateUpdate()
    {
        transform.position = offset + PlayerParent.transform.position;
        //sets the camera's position as the Player's but is offset by the calculated distance
    }
}
