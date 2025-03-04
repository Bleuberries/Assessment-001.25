using UnityEngine;
using TMPro; //Import this if using TextMeshPro
public class CoinCounter : MonoBehaviour
{
    public int CoinCount = 0; // Stores the number of coins collected
    public TextMeshProUGUI coinText; //Reference to the UI text

    void Start()
    {
        UpdateCoinUI();
    }

    public void AddCoin(int amount)
    {
        CoinCount += amount;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        coinText.text = "Coins: " + CoinCount.ToString();
    }
}
