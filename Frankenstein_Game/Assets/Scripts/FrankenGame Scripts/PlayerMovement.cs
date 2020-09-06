using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMovement : MonoBehaviour
{
    #region Player Stuff
    private GameObject PlayerParent, TopPlayer, BottomPlayer;
    private Rigidbody2D ParentRB,TopRB,BottomRB;
    private WorldFlip worldFlip;
    private float x,speed = 6f;
    #endregion
    #region Menu Stuff
    public Canvas MainCanvas;
    private MenuController MController;
    #endregion
    private void Awake()
    {
    MController = MainCanvas.GetComponent<MenuController>();
    PlayerParent = GameObject.Find("Player"); BottomPlayer = GameObject.Find("BottomPlayer"); TopPlayer = GameObject.Find("TopPlayer");//Finding Player objects
    ParentRB = PlayerParent.GetComponent<Rigidbody2D>();
    worldFlip = PlayerParent.GetComponent<WorldFlip>();
    }
    void Update()
    {
    ///////////Player Controls///////////////
    ///Player Controls are enabled after the game actually starts///
    if(MController.GameStarted == true || MController.GamePaused == false)
        {
    /////Left or Right Movement of the player *NOTE* that the controls are based on which camera is active to ensure the controls stay the same./////
            x = 0.0f;
            if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
            {
                if (worldFlip.CamTracker == 1)
                {
                    x = speed;
                }
                else if (worldFlip.CamTracker == 2)
                {
                    x = speed;
                }
            }//Right movement 
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
            {
                if (worldFlip.CamTracker == 1)
                {
                    x = -speed;
                }
                else if (worldFlip.CamTracker == 2)
                {
                    x = -speed;
                }
            }//Left movement
            if (worldFlip.CamTracker == 1)
            {
                BottomRB = BottomPlayer.GetComponent<Rigidbody2D>();
                BottomRB.velocity = ParentRB.velocity;
            }
            if (worldFlip.CamTracker == 2)
            {
                TopRB = TopPlayer.GetComponent<Rigidbody2D>();
                TopRB.velocity = ParentRB.velocity;
            }
            ParentRB.velocity = new Vector2(x, 0f);
    /////Pause menu controls/////
            if(Input.GetKeyDown(KeyCode.P))
            {
                MController.GamePaused = true;
            }
        }
   
    }
}