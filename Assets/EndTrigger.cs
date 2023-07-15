using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public GameManager gameManager;
    void OnTriggerEnter(Collider other)
    {
        if (SceneManager.GetActiveScene().buildIndex <= 2) { 
        gameManager.CompleteLevel();
        }
    }
}
