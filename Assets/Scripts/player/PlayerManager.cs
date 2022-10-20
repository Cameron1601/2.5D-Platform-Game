using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{
    public static int currentHealth = 100;
    public Slider healthBar;
    public static bool gameOver;

    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;

    void Start()
    {
        numberOfCoins = 0;
        gameOver = false;
    }

    void Update()
    {
        
        
        numberOfCoinsText.text = "Coins: " + numberOfCoins;

        healthBar.value = currentHealth;

        if (currentHealth < 0)
        {
            gameOver = true;
        }


    }
}