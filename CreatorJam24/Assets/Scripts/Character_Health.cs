using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.UI;

public class Character_Health : MonoBehaviour
{
    public float health;
    public float maxHealth;
    public Image HealthBar;

    public Sprite MaxHealth;
    public Sprite HalfHealth;
    public Sprite LowHealth;

    private SpriteRenderer spriteRenderer;

    private bool isDead;
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        isDead = false;
        Debug.Log("Start: Health initialized to " + health);
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);
        Debug.Log("Update: Health is " + health);

        if (health > maxHealth * 0.7f)
        {
            spriteRenderer.sprite = MaxHealth;
        }
        else if (health > maxHealth * 0.4f)
             {
                 spriteRenderer.sprite = HalfHealth;
             }
        else
        {
            spriteRenderer.sprite = LowHealth;
        }
        if (health <= 0 && !isDead)
        {
            isDead = true;
            gameObject.SetActive(false); 
            gameManager.gameOver();  
            Debug.Log("Dead");
        }
    }
}

