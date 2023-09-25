using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seek : MonoBehaviour
{
	GameObject moveTowardsThis;

	void Start()
	{
		Transform moveTowardsThis = GameObject.Find("Player").transform;
	}

    void Update()
	{
		transform.position = Vector3.MoveTowards(transform.position, transform.position, 0.005f);
	}
}
