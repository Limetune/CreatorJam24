using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinPickup : MonoBehaviour
{
    public int Coins = 0;
    public AudioClip pickupSound;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Coins++;
            Debug.Log("Coins" + Coins);
            AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            Destroy(gameObject);
        }

    }
}