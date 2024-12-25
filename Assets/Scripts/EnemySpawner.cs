using UnityEngine;
using System.Collections.Generic;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float spawnInterval = 2f;
    public Transform[] spawnPoints;
    public int maxEnemies = 10;

    private List<GameObject> enemies = new List<GameObject>();

    void Start()
    {
        InvokeRepeating("SpawnEnemy", spawnInterval, spawnInterval);
    }

    void SpawnEnemy()
    {
        if (enemies.Count >= maxEnemies)
        {
            return;
        }

        int spawnIndex = Random.Range(0, spawnPoints.Length);
        GameObject newEnemy = Instantiate(enemyPrefab, spawnPoints[spawnIndex].position, Quaternion.identity);
        enemies.Add(newEnemy);
    }

    void Update()
    {
        // Clean up destroyed enemies from the list
        enemies.RemoveAll(enemy => enemy == null);
    }
}