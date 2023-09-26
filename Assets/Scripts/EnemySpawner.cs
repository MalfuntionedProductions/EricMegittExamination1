using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] Vector2 spawnCircleOrigin;
    [SerializeField] float spawnCircleRadius;

    Transform playerTransform;
        
    
    [SerializeField] List<Vector2> spawnPoints;
    [SerializeField] GameObject s;

    [SerializeField] int startAmount = 15;
    [SerializeField] GameObject EnemyParentObject;
    
    void Start()
    {
        playerTransform = GameObject.FindWithTag("Player").transform;
        for (int i = 0; i < startAmount; i++)
            InstantiateEnemySpore();
        InvokeRepeating(nameof(InstantiateEnemySpore), 1, .5f);
    }

    Vector2 RandomSpawnPosition()
    {
        do
        {
            float r = spawnCircleRadius * Mathf.Sqrt(Random.Range(0f, 1f));
            float theta = Random.Range(0, 2 * Mathf.PI);
            Vector2 spawnPos = (new Vector2(Mathf.Cos(theta), Mathf.Sin(theta)) * r) + spawnCircleOrigin;
        } while (Vector2.Distance(playerTransform.position, spawnPos));
        return suggestedPosition;
    }
    
    void InstantiateEnemySpore()
    {
        GameObject enemy = Instantiate(s, transform.position + (Vector3)RandomPointWithinSpawnCircle()/*spawnPoints[Random.Range(0, spawnPoints.Count - 1)]*/, Quaternion.identity);
        enemy.transform.parent = EnemyParentObject.transform;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawSphere(spawnCircleOrigin, spawnCircleRadius);
        
        /*foreach (Vector3 pos in spawnPoints)
        {
            Gizmos.DrawSphere(pos, 1);
        }*/
    }
}