using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //If you want to update a UI Text Element 
public class GameManager : MonoBehaviour
{
    public static GameManager Instance; //Singleton instance

    public int coinCount = 0; 
    public Text coinText; //Drag your UI Text element here in the inspector 

    void Awake()
    {
        //Set up the singleton instance
        if(Instance == null)
            Instance = this;
        else 
            Destroy(gameObject);
    }

    public void AddCoin()
    {
        coinCount++;
        UpdateCoinUI();
    }

    void UpdateCoinUI()
    {
        if(coinText != null)
            coinText.text = "Coins: " + coinCount;
    }
}
