using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class WorldFlip : MonoBehaviour
{
    #region Camera Tracking
    private GameObject Cam1, Cam2;
    public Camera cam1, cam2;
    public Canvas MainCanvas;
    public int CamTracker;
    #endregion
    #region Player Flip
    private GameObject BottomPlayer, TopPlayer;
    #endregion
    private void Awake()
    {
    BottomPlayer = GameObject.Find("BottomPlayer"); TopPlayer = GameObject.Find("TopPlayer");//Finding Player Objects
    Cam1 = GameObject.Find("Cam1"); Cam2 = GameObject.Find("Cam2");//Finding Cameras
    CamTracker = 1;
    }
    // Update is called once per frame
    void Update()
    {
    if(MainCanvas.GetComponent<MenuController>().GameStarted == true || MainCanvas.GetComponent<MenuController>().GamePaused == false)
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (CamTracker == 1)
                {
                    CamTracker += 1;
                }
                else if (CamTracker == 2)
                {
                    CamTracker -= 1;
                }
            }
            if (CamTracker == 1)
            {
                Cam1.SetActive(true); Cam2.SetActive(false);//Setting Active Camera
                BottomPlayer.SetActive(true); TopPlayer.SetActive(false);//Setting Active Player Objects
                MainCanvas.worldCamera = cam1;
            }
            if (CamTracker == 2)
            {
                Cam1.SetActive(false); Cam2.SetActive(true);//Setting Active Camera
                BottomPlayer.SetActive(false); TopPlayer.SetActive(true);//Setting Active Player Objects
                MainCanvas.worldCamera = cam2;
            }
        }    
    }
}
