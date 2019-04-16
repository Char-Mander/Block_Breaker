using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class GameSession : MonoBehaviour
{
    //Config parameters
    [Range(0.1f, 10f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlockDestroyed = 10;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] bool isAutoPlayEnabled;

    //State variables
    [SerializeField] int currentScore = 0;

    private void Awake()
    { 
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;

        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

    public bool IsAutoPlayEnabled()
    {
        return isAutoPlayEnabled;
    }

    private void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    private void Update()
    {
        Time.timeScale = gameSpeed;
        scoreText.text = currentScore.ToString();

    }

    public void AddToScore()
    {
        currentScore += pointsPerBlockDestroyed;
    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }
}
