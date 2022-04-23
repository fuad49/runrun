using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Obstacle", menuName = "Obstacles")]
public class Obstacles : ScriptableObject
{
    public GameObject[] prefabs;
    public Color[] col;
}
