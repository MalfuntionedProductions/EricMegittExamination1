using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Doer_Temp_Final_V3 : MonoBehaviour
{
    [SerializeField] float movementSpeed = 5f;
    
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * Time.fixedDeltaTime, Input.GetAxis("Vertical") * Time.fixedDeltaTime, 0);
    }
}
