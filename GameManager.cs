using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    public static event Action OnGameStart; // Evento estático

    private void Start()
    {
        StartGame();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    private void StartGame()
    {
        Debug.Log("Game started!");

        // Disparar o evento OnGameStart, caso haja algum assinante
        OnGameStart?.Invoke();
    }
}
