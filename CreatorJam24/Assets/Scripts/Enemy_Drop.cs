using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Enemy_Drop : MonoBehaviour
{
    public float enemy_Health;
    public GameObject moneyPrefab; // Referens till pengar-prefaben
    private int moneyDropAmount = 1;
    public float bullet_Damage;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Bullet")
        {
            enemy_Health -= bullet_Damage;
            Destroy(collision.gameObject);
            
            if (enemy_Health <= 0)
            {
                Die();
            }
        }
    }

    // Funktion som körs när fienden dör
    void Die()
    {
        DropMoney();
        Destroy(gameObject);
    }

    // Funktion för att släppa pengar
    void DropMoney()
    {
        for (int i = 0; i < moneyDropAmount; i++)
        {
            Instantiate(moneyPrefab, transform.position, Quaternion.identity);
        }
    }
}
