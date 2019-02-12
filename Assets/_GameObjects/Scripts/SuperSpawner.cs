using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuperSpawner : MonoBehaviour {
    [SerializeField] Transform x0z0;
    [SerializeField] Transform x1;
    [SerializeField] Transform z1;
    [SerializeField] GameObject[] prefab;
    [SerializeField] int numberOfObjects;

    float xR;//x random
    float zR;//z random
    int pR;//prefab random
    private void Awake()
    {
        for (int i = 0; i < numberOfObjects; i++)
        {
            xR = Random.Range(x0z0.position.x, x1.position.x);
            zR = Random.Range(x0z0.position.z, z1.position.z);
            pR = Random.Range(0, prefab.Length);
            Instantiate(prefab[pR], new Vector3(xR, 0, zR), Quaternion.identity);
        }
    }

}
