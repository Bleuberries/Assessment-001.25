using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //changes scene

public class SceneChanger : MonoBehaviour
{
    //Ensure your trigger has "Is Trigger" enabled
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player")) //Make sure your player has the tag "Player" 
        {
            SceneManager.LoadScene("NextScene"); //Replace "NextScene" with your actual scene name
        }
    }
    
}
