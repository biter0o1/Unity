using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class Zad5 : MonoBehaviour
{
    public GameObject myPrefab;
    private List<Vector3> randomList = new List<Vector3>();

    void Start()
    {

        for (int i = 0; i < 10; i++)
        {
            Vector3 v = new Vector3(Random.Range(-10, 10), 5, Random.Range(-10, 10));

            while (randomList.Contains(v))
            {
                v = new Vector3(Random.Range(-10, 10), 5, Random.Range(-10, 10));
            }
            randomList.Add(v);
        }

        for (int i = 0; i < 10; i++)
        {
            Instantiate(myPrefab, randomList[i], Quaternion.identity);
        }
    }
}
