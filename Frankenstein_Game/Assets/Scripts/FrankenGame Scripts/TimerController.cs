using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Threading;
public class TimerController : MonoBehaviour
{
    #region Timer
    public int timeLeft, currentTime;
    public Text countDown;
    public bool setTimer;
    private MenuController MControl;
    #endregion
    private void Awake()
    {
    MControl = GameObject.Find("Canvas").GetComponent<MenuController>();
    currentTime = timeLeft;
    }
    private void Start()
    { 
        StartCoroutine("LoseTime");
        Time.timeScale = 1;
    }
    // Update is called once per frame
    void Update()
    {
        if (MControl.GameStarted == true)
        {
                countDown.text = ("" + timeLeft);
                if (timeLeft <= 0)
                {
                    timeLeft = 0;
                }
        }
        if (MControl.GamePaused == true)
        {
            if(setTimer == false)
            {
                PauseTime();
            }
        }
        if(MControl.GamePaused == false)
        {
            setTimer = false;
        }
        if(MControl.GameStarted == false)
        {
           if(timeLeft > 0)
            {
                timeLeft = currentTime;
            }
        }
    }
    IEnumerator LoseTime()
        {
        while (true)
        {
            yield return new WaitForSeconds(1);
            timeLeft --;
        }
        }
    public void SetTime()
        {
        timeLeft = currentTime;
        }
    public void PauseTime()
    {
        currentTime = timeLeft;
        setTimer = true;
    }
}
