using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlternativeMovement : MonoBehaviour
{
    void FixedUpdate()
    {
        transform.Translate(.02f, 0, 0);
        transform.Rotate(0, 0, .2f, Space.Self);
    }
}
