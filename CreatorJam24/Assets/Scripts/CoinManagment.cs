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

    void Update()
    {
        coinText.text = ": " + coinCount.ToString();
    }
}
