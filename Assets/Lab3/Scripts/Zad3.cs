using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zad3 : MonoBehaviour
{
    public float speed;
    private string forward = "UP";

    private void Update()
    {
        if (forward == "UP")
        {
            transform.Translate(10 * speed * Time.deltaTime, 0, 0);
            if (transform.position.x >= 10) forward = "RIGHT";

        }
        else if (forward == "RIGHT")
        {
            transform.Translate(0, 0, 10 * speed * Time.deltaTime);
            if (transform.position.z >= 10) forward = "DOWN";

        }
        else if (forward == "DOWN")
        {
            transform.Translate(-10 * speed * Time.deltaTime, 0, 0);
            if (transform.position.x <= 0) forward = "LEFT";

        }
        else if (forward == "LEFT")
        {
            transform.Translate(0, 0, -10 * speed * Time.deltaTime);
            if (transform.position.z <= 0) forward = "UP";
        }

    }
}
