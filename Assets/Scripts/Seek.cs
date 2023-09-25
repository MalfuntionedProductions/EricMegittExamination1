using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
	Transform targetTransform;

	void Start()
	{
		targetTransform = GameObject.FindWithTag("Player").transform;
	}

    void FixedUpdate()
	{
		transform.position = Vector3.MoveTowards(transform.position, targetTransform.position, 0.005f);
	}
}
