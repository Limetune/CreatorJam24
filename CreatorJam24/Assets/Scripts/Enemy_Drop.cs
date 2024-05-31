using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Drop : MonoBehaviour
{
    public float health;
    public GameObject moneyPrefab; // Referens till pengar-prefaben
    private int moneyDropAmount = 1; 

    // Funktion f�r att ta skada
    public void TakeDamage(float damage)
    {
        health -= damage;
        if (health <= 0)
        {
            Die();
        }
    }

    // Funktion som k�rs n�r fienden d�r
    void Die()
    {
        DropMoney();
        Destroy(gameObject);
    }

    // Funktion f�r att sl�ppa pengar
    void DropMoney()
    {
        for (int i = 0; i < moneyDropAmount; i++)
        {
            Instantiate(moneyPrefab, transform.position, Quaternion.identity);
        }
    }
}
