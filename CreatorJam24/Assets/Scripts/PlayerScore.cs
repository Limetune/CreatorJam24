using UnityEngine;
using UnityEngine.UI; // Optional: only if you want to update a UI element

public class PlayerScore : MonoBehaviour
{
    public int score = 0;
    public Text scoreText; // Optional: UI Text to display score

    public void AddCoins(int amount)
    {
        score += amount;
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        if (scoreText != null)
        {
            scoreText.text = "Score: " + score.ToString();
        }
    }
}