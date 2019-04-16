using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level : MonoBehaviour
{
    //Parameters
    [SerializeField] int breakableBlocks; //Serialize for debugging purposes

    //Cached reference
    SceneLoader sceneloader;

    public void Start()
    {
        sceneloader = FindObjectOfType<SceneLoader>();
    }

    public void CountBlocks()
    {
        breakableBlocks++;  
    }

    public void BlockDestroyed()
    {
        breakableBlocks--;

        if (breakableBlocks <= 0)
        {
            sceneloader.LoadNextScene();
        }
    }
}
