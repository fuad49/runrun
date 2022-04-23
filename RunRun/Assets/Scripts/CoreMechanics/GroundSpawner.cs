﻿using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTile;
    public Vector3 nextSpawnPoint;

    public void SpawnTile(bool spawnItems)
    {
        GameObject temp = Instantiate(groundTile, nextSpawnPoint, Quaternion.identity);
        nextSpawnPoint = temp.transform.GetChild(1).transform.position;

        if(spawnItems)
            temp.GetComponent<GroundTIle>().SpawnObstacle();
    }

    void Start()
    {
        for(int i = 0; i < 15; i++)
        {
            if(i < 3)
                SpawnTile(false);
            else
                SpawnTile(true);
        }
    }
}