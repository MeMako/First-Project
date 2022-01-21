using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   
 /*   public GameObject gameobject;
    public float jumpSpeed = 5.0f;
    public Vector3 jump;
    public bool isGrounded;
 */
    public float gravity = -9.81f;

    Vector3 velocity;

    public float speed=10f;

    public CharacterController controller;

   // private void OnCollisionStay()
    //{isGrounded = true;}
    
    //private Rigidbody rb;
      private void Start()
    {
        //public bool isGrounded
    //    rb = GetComponent<Rigidbody>();
      //  jump = new Vector3(0.0f, 2.0f, 0.0f);
    }


 

    // Update is called once per frame
    void Update()
    {
        velocity.y += gravity * Time.deltaTime;
        float X = Input.GetAxis("Horizontal");
        float Z = Input.GetAxis("Vertical");
        Vector3 move = transform.right * X + transform.forward * Z;
        controller.Move(move*speed*Time.deltaTime);
        controller.Move(velocity * Time.deltaTime);
        //if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        /*{
            transform.Translate(1f, 1f, 1f);
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
           isGrounded = false;
        }*/


    }
}
