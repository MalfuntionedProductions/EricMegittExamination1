using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
	Transform playerTransform;
	
	void Start()
	{
		playerTransform = GameObject.FindWithTag("Player").transform;
	}

    void Update()
    {
        transform.position = playerTransform.position + new Vector3(0, 0, -10);
    }
}
