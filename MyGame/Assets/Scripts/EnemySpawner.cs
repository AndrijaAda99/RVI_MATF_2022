using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> spawnedEnemies;

    [SerializeField] GameObject enemyPrefab;
    [SerializeField] List<Transform> spawnPoints;
    [SerializeField] int numberOfEnemies;
    [SerializeField] int spawnTime;

    private Coroutine spawnCoroutine;
    
    public IEnumerator SpawnCoroutine(int timeForSpawn)
    {
        System.Random randomIndex = new System.Random();

        while (true)
        {
            int index = randomIndex.Next(0, spawnPoints.Count);
            Vector3 spawnPosition = spawnPoints[index].position;

            GameObject enemy = Instantiate(enemyPrefab, spawnPosition, Quaternion.identity);

            spawnedEnemies.Add(enemy);
            
            if (spawnedEnemies.Count > numberOfEnemies) {
                yield break;
            }

            yield return new WaitForSecondsRealtime(timeForSpawn);
        }
        
    }

    void Awake()
    {
        spawnedEnemies = new List<GameObject>();
    }

    void Start()
    {
        StartCoroutine(SpawnCoroutine(spawnTime));
    }

    void Update()
    {
        
    }
}
