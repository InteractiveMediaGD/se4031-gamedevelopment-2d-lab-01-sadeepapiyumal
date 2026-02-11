using UnityEngine;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth;

    public TMP_Text healthText;

    void Start()
    {
        currentHealth = maxHealth;
        UpdateUI();
    }

    void UpdateUI()
    {
        healthText.text = "Health: " + currentHealth;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Obstacle"))
        {
            currentHealth -= 10;

            if (currentHealth < 0)
                currentHealth = 0;

            UpdateUI();

            if (currentHealth == 0)
                Time.timeScale = 0f;
        }
    }
}