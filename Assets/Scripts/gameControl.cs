﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    public GameObject hazard;
    public Vector3 spawnValues;
    
    void Start()
    {
        SpawnWaves();
    }


    void SpawnWaves()
    {
       for(int i=0;i<hazardCount;i++)
       {
                 Vector3 spawnPosition = new Vector3(Random.Range (-spawnValues.x, spawnValues.x),spawnValues.y,spawnValues.z);
                 Quaternion spawnRotation = Quaternion.identity;
                 Instantiate (hazard, spawnPosition,spawnRotation);
       }
     }
}
