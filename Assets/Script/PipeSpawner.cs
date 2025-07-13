using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using Random = UnityEngine.Random;


public class PipeSpawner : MonoBehaviour
{
    [FormerlySerializedAs("pipeObjcetPooling")] [SerializeField] PipeObjectPooling pipeObjectPooling;
    [SerializeField] private Transform maxYSpawnPoint;
    [SerializeField] private Transform minYSpawnPoint;
    [SerializeField] float timeBetweenSpawns;
    
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= timeBetweenSpawns)
        {
            timer = 0f;
            SpawnPipe();
        }
    }
    
    void SpawnPipe()
    {
        GameObject pipe = pipeObjectPooling.Spawn();
        float randomPositionToSpawn = Random.Range(minYSpawnPoint.position.y, maxYSpawnPoint.position.y);
        pipe.transform.position = new Vector2(transform.position.x,randomPositionToSpawn);
        Debug.Log( pipe.transform.position);
    }
}
