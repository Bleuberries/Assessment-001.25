using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Coin : MonoBehaviour
{
    //Optionally, you can add a coin collection sound or update score via a GameManager
    void OnTriggerEnter2D(Collider2D other)
    {
        //Check if the colliding object has the tag "Player"
        if (other.CompareTag("Player"))
        {
            //Optional: Update score or play a sound here
            //Example: GameManager.Instance.AddCoin();

            //Remove the coin from the scene
            Destroy(gameObject);
        
        }
    }

}
