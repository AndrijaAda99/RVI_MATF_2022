using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    List<GameObject> spawnedEnemies;
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] List<Vector3> spawnPoints;
    [SerializeField] int numberOfEnemies;
    
    public GameObject SpawnEnemy()
    {
        int randomIndex = Random.Range(0, spawnPoints.Capacity);
        GameObject enemy = Instantiate(enemyPrefab);
        enemy.transform.position = spawnPoints[randomIndex];
        enemy.GetComponent<Enemy>().player = GameObject.Find("Player");
        return enemy;
    }

    void Awake()
    {
        spawnedEnemies = new List<GameObject>();
    }

    void Start()
    {
        for (int i = 0; i < numberOfEnemies; i++)
        {    
            spawnedEnemies.Add(SpawnEnemy());   
        }
    }

    void Update()
    {
        
    }
}
