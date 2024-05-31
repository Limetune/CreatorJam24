using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public int Coins = 0;
    public TextMeshProUGUI PointText;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            Coins++;
            Debug.Log("Coins" + Coins);
            Destroy(collision.gameObject);
        }

    }
}