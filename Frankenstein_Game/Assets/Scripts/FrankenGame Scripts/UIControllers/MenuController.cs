using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
public bool GameStarted = false, GamePaused;
private GameObject PauseMenu, ControlsMenu,MainMenu,CustomizationMenu,EndMenu;
public FinishScript F_Control;
public int Current_Count;
private void Awake()
    {
    F_Control = GameObject.Find("BottomPlayer").GetComponent<FinishScript>();
    PauseMenu = GameObject.Find("PausePanel");ControlsMenu = GameObject.Find("ControlsPanel");
    MainMenu = GameObject.Find("MainMenuPanel"); CustomizationMenu = GameObject.Find("PlayerCustomizationPanel");
    EndMenu = GameObject.Find("End");
    GamePaused = false;
    }
private void Update()
    {
        if(Input.GetKeyDown(KeyCode.P))
        {
            PauseMenu.SetActive(true);
        }
        else if(GamePaused == false)
        {
            PauseMenu.SetActive(false);
        }
        if(F_Control.Win || F_Control.Lose)
        {
            EndMenu.SetActive(true);
        }
        else if(F_Control.Win == false || F_Control.Lose == false)
        {
            EndMenu.SetActive(false);
        }
    }
public void StartGame()
    {
        GameStarted = true;
    }
public void PauseGame()
    {
        GamePaused = false;
    }
public void PauseMenuReturn()
    {
        if(GamePaused == true)
        {
            PauseMenu.SetActive(true);
            ControlsMenu.SetActive(false);
        }
        else
        {
            ControlsMenu.SetActive(true);
        }
    }
}
