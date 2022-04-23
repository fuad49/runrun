using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpawner : MonoBehaviour
{
    [SerializeField]private PlayerList pl;
    [SerializeField]private PlayerTexture pt;
    private Vector3 spawnPoint = new Vector3(0, 3, 0);
    void Awake()
    {
        int playerIndex = PlayerPrefs.GetInt("PlayerToSpawn", 0);
        int playerColorIndex = Random.Range(0, pt.color.Length);
        Instantiate(pl.playerList[playerIndex], spawnPoint, Quaternion.identity, transform);
        
        Renderer rend = GameObject.FindGameObjectWithTag("Player").GetComponent<Renderer>();
        // rend.material.color = pt.color[playerColorIndex];
 
        //rend.sharedMaterial.color = Random.ColorHSV();
    }
}
