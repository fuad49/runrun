using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
   [SerializeField]private float speed = 25f;
   [SerializeField]private Rigidbody rb;
   [SerializeField]private float horizontalMultiplier = 1.5f;

   [SerializeField] private float jumpForce = 600f;
   [SerializeField] LayerMask groundMask;

   [SerializeField] bool canJump = true;
   [SerializeField] float jumpInterval = 3.5f;

   float horizontalInput;
   void FixedUpdate()
   {

       Vector3 forwardMove = transform.forward * speed * Time.deltaTime;
       Vector3 horizontalMove = transform.right * horizontalInput * speed * Time.deltaTime * horizontalMultiplier;
       rb.MovePosition(rb.position + forwardMove + horizontalMove);

       if(Input.GetKeyDown(KeyCode.R))
       {
         SceneManager.LoadScene(1);
       }
   }

   void Update()
   {
       horizontalInput = Input.GetAxis("Horizontal");

       if(Input.GetKeyDown(KeyCode.Space) && canJump)
       {
         StartCoroutine(Jump(jumpInterval));
       }

       if(transform.position.y <= -5)
       {
         //Saves.insts.SaveData();
       }
   }



   IEnumerator Jump(float jumptime)
   {
      canJump = false;
      float height = GetComponent<Collider>().bounds.size.y;
      bool isGrounded = Physics.Raycast(transform.position, Vector3.down, (height / 2) +0.1f, groundMask );

      rb.AddForce(Vector3.up * jumpForce);

      yield return new WaitForSeconds(jumptime);
      canJump = true;
   }
}

