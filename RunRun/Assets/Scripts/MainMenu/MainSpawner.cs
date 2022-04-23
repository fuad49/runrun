using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainSpawner : MonoBehaviour
{
    [SerializeField] private PlayerList pl;
    [SerializeField] private Transform spawnplace;
    [SerializeField] private Vector3 spawnPoint;
    public int arrayNo;
    private void Start() 
    {   
        spawnPoint = new Vector3(spawnplace.position.x,spawnplace.position.y,spawnplace.position.z);

        int spawanIndex = PlayerPrefs.GetInt("PlayerToSpawn", 0);

        Instantiate(pl.playerList[spawanIndex], spawnPoint, Quaternion.identity, transform);

        spawnplace.GetComponentInChildren<PlayerAttributes>().enabled = false;
        
    }

    public void NextPlayer()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if(playerObj != null) Destroy(playerObj);

            arrayNo++;
        
    }
    public void PreviousPlayer()
    {
        GameObject playerObj = GameObject.FindGameObjectWithTag("Player");
        if(playerObj != null) Destroy(playerObj); 

    
            arrayNo = arrayNo - 1;
        

    }

    private void Update() 
    {
        if(arrayNo == 9) arrayNo = 0;
        if(arrayNo == -1) arrayNo = 8;

        if(spawnplace.childCount == 0 && arrayNo > -1 && arrayNo < pl.playerList.Length)
        {
            SpawnPlayer(arrayNo);
        }
    }

    public void SpawnPlayer(int arr)
    {
        Instantiate(pl.playerList[arr], spawnPoint, Quaternion.identity, transform);
    }
}
