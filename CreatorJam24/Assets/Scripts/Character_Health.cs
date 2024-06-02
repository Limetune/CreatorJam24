using System.Collections;
using System.Collections.Generic;
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

    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        HealthBar.fillAmount = Mathf.Clamp(health / maxHealth, 0, 1);

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
            Destroy(gameObject);
            Debug.Log("Dead");
        }
    }
}

