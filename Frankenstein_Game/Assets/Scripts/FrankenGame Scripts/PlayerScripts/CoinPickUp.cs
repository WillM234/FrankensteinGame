using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinPickUp : MonoBehaviour
{
    public int  Coin_Total;
    public Text PlayerCoins;
    public AudioClip CoinSound;
    public AudioSource A_Source;
    public MenuController M_Control;
    private void Update()
    {
    PlayerCoins.text = ("Coins collected: " + M_Control.Current_Count + " / " + Coin_Total);
    A_Source = GameObject.Find("Player").GetComponent<AudioSource>();
    M_Control = GameObject.Find("Canvas").GetComponent<MenuController>();
    }
    private void OnTriggerEnter2D(Collider2D coin)
    {
      if(coin.gameObject.tag == "CoinPickUp")
        {
            M_Control.Current_Count += 1;
            if(A_Source.isPlaying == false)
            {
                A_Source.PlayOneShot(CoinSound);
            }
        }
    }
}
