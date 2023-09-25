using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variety3 : MonoBehaviour
{
    

    void FixedUpdate()
    {
        transform.position += new Vector3(Random.Range(-.01f, .01f), Random.Range(-.01f, .01f), 0);
    }
}
