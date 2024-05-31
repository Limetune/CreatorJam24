using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CoinManagment : MonoBehaviour
{
    public int coinCount;
    public GameObject Coin;
    public Text coinText;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Coin")
        {
            coinCount++;
            Destroy(collision.gameObject);
        }
    }
    void Update()
    {
        coinText.text = ": " + coinCount.ToString();
    }
}
