using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyInstantiate : MonoBehaviour
{
    public Transform[] spawnLocations;
    public GameObject enemy;
    int start = 0;
    
    void Start()
    {
        
    }

    
    void FixedUpdate()
    {
        start += 1;

        if(start > 100)
        {
            int RandomLoc = Random.Range(0, 4);
            Instantiate(enemy, spawnLocations[RandomLoc].position, Quaternion.identity);
            start = 0;
        }


    }
}
