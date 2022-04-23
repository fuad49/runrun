using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttributes : MonoBehaviour
{
    [SerializeField] private bool isSphare;
    [SerializeField] private float angle = 90f;


    private void Update()
    {   
        if(isSphare)
            transform.Rotate(angle*Time.deltaTime, angle*Time.deltaTime, angle*Time.deltaTime);    
    }
}
