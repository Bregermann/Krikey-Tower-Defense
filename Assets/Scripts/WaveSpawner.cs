using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;

public class WaveSpawner : MonoBehaviour
{
    public Transform[] enemyPrefab;
    public Transform spawnPoint;
    public int currentWave = 1;

    public float timeBetweenEnemies = 1f;
    public float timeBetweenWaves = 3f;

    private int waveNumber = 1;

    void Update()
    {
        if(timeBetweenEnemies <= 0f)
        {
            SpawnWave();
            timeBetweenEnemies = 1;
        }
        timeBetweenEnemies -= Time.deltaTime;
    }
    IEnumerator SpawnWave()
    {
        for (int i = 0; i < 20; i++)
        {
            SpawnEnemy();
            yield return new WaitForSeconds(1f);
        }
    }
    void SpawnEnemy()
    {
        Instantiate(enemyPrefab[currentWave], spawnPoint.position, spawnPoint.rotation);
    }
}
