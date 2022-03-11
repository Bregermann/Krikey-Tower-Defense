using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static int playerHealth;
    public static int totalWaves;
    public static int currentWave;

    void Start()
    {
        playerHealth = 5;
        totalWaves = 2;
    }

    void Update()
    {
        if(playerHealth == 0)
        {
            GameOver();
        }
        if(currentWave == 3)
        {
            YouWin();
        }
    }
    void GameOver()
    {
        //you lose
    }
    void YouWin()
    {

    }
}
