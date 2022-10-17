using TMPro;
using UnityEngine;

public class PlayerManager : MonoBehaviour

{
    public static int numberOfCoins;
    public TextMeshProUGUI numberOfCoinsText;
    void Start()
    {
        numberOfCoins = 0;
    }

    // Update is called once per frame
    void Update()
    {
        numberOfCoinsText.text = "Coins: " + numberOfCoins;
    }
}
