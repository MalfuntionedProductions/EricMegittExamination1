using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wobble : MonoBehaviour
{
    float wobbleSpeed = .002f;

    [SerializeField] int wobbleMultiplier = 1;
    
    void FixedUpdate()
    {
        // should probably make it so the things cant look bad
        for (int i = 0; i < wobbleMultiplier; i++)
            transform.localScale += new Vector3(Random.Range(-wobbleSpeed, wobbleSpeed), Random.Range(-wobbleSpeed, wobbleSpeed), 0);
    }
}
