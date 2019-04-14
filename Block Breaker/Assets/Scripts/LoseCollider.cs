using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Loads the "Game Over" scene when the ball falls
        SceneManager.LoadScene("Game Over"); 
    }

}
