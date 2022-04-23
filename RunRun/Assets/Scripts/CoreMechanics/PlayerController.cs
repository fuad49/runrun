using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    [SerializeField]float horizontalInput;
    [SerializeField]float horizontalMultiplier = 5f;


    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * horizontalMultiplier, Space.World);

    }
}
