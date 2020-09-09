using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FinishScript : MonoBehaviour
{
    public bool Win, Lose;
    public TimerController T_Control;
    public MenuController M_Control;
    public CoinPickUp C_Control;
    public Text EndText, coinText;
    private void Awake()
    {
        T_Control = GameObject.Find("Canvas").GetComponent<TimerController>();
        M_Control = GameObject.Find("Canvas").GetComponent<MenuController>();
        C_Control = GameObject.FindGameObjectWithTag("Player").GetComponent<CoinPickUp>();
    }
    private void Update()
    {
        if(T_Control.timeLeft <= 0  && M_Control.GamePaused == false)
        {
            Lose = true;  
        }
        else
        {
            Lose = false;
        }
        if(Win)
        {
            EndText.text = "You won! Click Restart to try again or Quit to leave the game.";
            coinText.text = ("You collected " + M_Control.Current_Count + " out of " + C_Control.Coin_Total + " coins!");
            M_Control.GamePaused = true;
            Lose = false;
        }
        if(Lose)
        {
            EndText.text = "You lose! Click Restart to try again or Quit to leave the game.";
            coinText.text = ("You collected " + M_Control.Current_Count + " out of " + C_Control.Coin_Total + " coins!");
            M_Control.GamePaused = true;
            Win = false;
        }
    }
    private void OnTriggerEnter2D(Collider2D End)
    {
        if(End.gameObject.tag == "FinishObject" && T_Control.timeLeft >= 0)
        {
            Win = true;
        }
        else
        {
            Win = false;
        }
    }
}
