using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    public int coinValue = 1; // Amount of coins this object represents
    public AudioClip pickupSound; // Optional: sound to play on pickup

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            // Add coin value to the player's score
            PlayerScore playerScore = other.GetComponent<PlayerScore>();
            if (playerScore != null)
            {
                playerScore.AddCoins(coinValue);
            }

            // Play pickup sound if it exists
            if (pickupSound != null)
            {
                AudioSource.PlayClipAtPoint(pickupSound, transform.position);
            }

            // Destroy the coin object
            Destroy(gameObject);
        }
    }
}
