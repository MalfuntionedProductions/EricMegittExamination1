using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety : MonoBehaviour
{
    [SerializeField] float movementSpeed = .05f;
    
    void FixedUpdate()
    {
        transform.position += new Vector3(Random.Range(-movementSpeed, movementSpeed), Random.Range(-movementSpeed, movementSpeed), 0);
    }
}
