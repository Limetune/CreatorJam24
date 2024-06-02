using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverUI;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        gameOverUI.SetActive(false); // Se till att game over UI:n är inaktiv vid start
        Debug.Log("GameManager Start: Game Over UI set to inactive.");
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void gameOver()
    {
        Debug.Log("Game Over triggered.");
        gameOverUI.SetActive(true);
    }
}
