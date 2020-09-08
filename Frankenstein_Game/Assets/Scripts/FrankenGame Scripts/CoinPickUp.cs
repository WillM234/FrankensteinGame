using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class CoinPickUp : MonoBehaviour
{
    public int Current_Count, Coin_Total;
    public Text PlayerCoins;
    private void Update()
    {
    PlayerCoins.text = ("Coins collected: " + Current_Count + " / " + Coin_Total); 
    }
    private void OnTriggerEnter2D(Collider2D coin)
    {
      if(coin.gameObject.tag == "CoinPickUp")
        {
            Current_Count += 1;
        }
    }
}
