using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
public bool GameStarted = false, GamePaused;
private GameObject PauseMenu, ControlsMenu,MainMenu,CustomizationMenu;
public FinishScript F_Control;

private void Awake()
    {
    PauseMenu = GameObject.Find("PausePanel");ControlsMenu = GameObject.Find("ControlsPanel");
    MainMenu = GameObject.Find("MainMenuPanel"); CustomizationMenu = GameObject.Find("PlayerCustomizationPanel");
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
