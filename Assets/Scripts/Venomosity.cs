using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Venomosity : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision2D) 
    {
        if (!collision2D.gameObject.CompareTag("dontforgettoupdatethetag")) 
            return;
        
        print("got me");
        Destroy(collision2D.gameObject);
        transform.localScale += new Vector3(.5f, .5f, 0);
    }
}