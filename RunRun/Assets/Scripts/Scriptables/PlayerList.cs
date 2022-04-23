using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Player", menuName = "Player List")]
public class PlayerList : ScriptableObject
{
    public GameObject[] playerList;
}
