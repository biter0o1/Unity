using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor;
using UnityEngine;

public class Zad2 : MonoBehaviour
{
    public float speed;
    bool forward = true;

    private void FixedUpdate()
    {
        if (forward)
        {
            if (transform.position.x >= 10)
            {
                forward = false;
            }
            transform.Translate(10 * speed * Time.deltaTime, 0, 0);
        }
        else
        {
            if (transform.position.x <= 0)
            {
                forward = true;
            }
            transform.Translate(-10 * speed * Time.deltaTime, 0, 0);
        }

    }
}
