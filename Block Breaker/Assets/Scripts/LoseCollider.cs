using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseCollider : MonoBehaviour
{
    //[SerializeField] AudioClip loseSound;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Loads the "Game Over" scene when the ball falls
        //GetComponent<AudioSource>().Play();
       // AudioSource.PlayClipAtPoint(loseSound, Camera.main.transform.position);

        SceneManager.LoadScene("Game Over"); 
    }

}
