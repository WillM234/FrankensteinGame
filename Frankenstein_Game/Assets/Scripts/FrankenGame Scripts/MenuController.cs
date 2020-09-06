using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class MenuController : MonoBehaviour
{
public bool GameStarted = false, GamePaused;
private GameObject PauseMenu, ControlsMenu,MainMenu,CustomizationMenu;
private void Awake()
    {
    PauseMenu = GameObject.Find("PausePanel");ControlsMenu = GameObject.Find("ControlsPanel");
    MainMenu = GameObject.Find("MainMenuPanel"); CustomizationMenu = GameObject.Find("PlayerCustomizationPanel");
        GamePaused = false;
    }
private void Update()
    {
        if(GamePaused == true)
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
}
