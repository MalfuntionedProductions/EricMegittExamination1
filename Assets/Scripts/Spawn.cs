using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] Transform[] a;
    [SerializeField] GameObject s;
    
    void Start()
    {
        InvokeRepeating(nameof(InstantiateEnemySpore), 1, .5f);
    }

    void InstantiateEnemySpore()
    {
        Instantiate(s, a[Random.Range(0, a.Length - 1)].transform.position, Quaternion.identity);
    }
}