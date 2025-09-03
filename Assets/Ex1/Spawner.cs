using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public float spawnRate = 2f;
    public List<GameObject> paredes = new List<GameObject>();
    void Start()
    {
        
    }

    float tempoCont;
    void Update()
    {
        tempoCont += Time.deltaTime;
        if (tempoCont >= spawnRate)
        {
            int index = Random.Range(0, paredes.Count);
            Instantiate(paredes[index], transform.position, Quaternion.identity);
            spawnRate += 2f;
            tempoCont = 0;
        }
    }
}
