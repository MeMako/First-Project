using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public GameObject gameObject;
    //this is how fast we go
    public float speed = 1.0f;
    public float jumpSpeed = 5.0f;
    public Vector3 jump;

    public bool isGrounded; //is a yes or no 
    private Rigidbody rb; //accesses the component in the editor


    private void Start()
    {
        //public bool isGrounded; 
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    public void Update()
    {
        //funk teleport script
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            //transform.Translate(1f, 1f, 1f);
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }

        //this gets the axis(directions) we want to go
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        //this tells us which way we're going to go
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        //Time.deltaTime so that it uses seconds rather than the computer
        transform.position += moveDirection * speed * Time.deltaTime;

    }
}
