using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    public float turnSpeed = 90f;
    [SerializeField] private bool isHorizontal;
    void OnTriggerEnter(Collider other)
    {

        if(other.gameObject.name != "Player")
        {
            return;
        }

        GameManager.inst.IncreamentCoin();

        Destroy(gameObject);
    }
        void Update()
    {
        if(!isHorizontal)
            transform.Rotate( 0 ,turnSpeed * Time.deltaTime, 0);
        
        else
            transform.Rotate(0, 0,  turnSpeed * Time.deltaTime);
    }
}
