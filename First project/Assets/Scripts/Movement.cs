using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject gameobject;
    //This is how fast we go
    public float speed = 3.0f;
    public float jumpSpeed = 5.0f;
    public Vector3 jump;

    public bool isGrounded; //is a yes or no
    private Rigidbody rb; //acceses the component in the editor
        

    private void Start()
    {
        //public bool isGrounded
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f,2.0f,0.0f);
    }

    private void OnCollisionStay()
    {
        isGrounded = true;
    }

    // Start is called before the first frame update
   
  
     

    // Update is called once per frame
    public void Update()
    {

        //Weird teleport script
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            //transform.Translate(1f, 1f, 1f);
            rb.AddForce(jump * jumpSpeed, ForceMode.Impulse);
            isGrounded = false;
        }
        
        if(Input.GetKey(KeyCode.W))
        {
            rb.velocity = transform.forward * speed;
        }

        
        
        if(Input.GetKey(KeyCode.S))
        {
            rb.velocity = -transform.forward * speed;
        }

        if(Input.GetKey(KeyCode.D))
        {
            float newspeed = speed;
            newspeed = newspeed + 10.0f;
            transform.Rotate(new Vector3(0, 1, 1) * Time.deltaTime*newspeed,Space.World);
        }

        if (Input.GetKey(KeyCode.A))
        {

            float newspeed = speed;
            newspeed = newspeed + 10.0f;
            transform.Rotate(new Vector3(0, -1, 1) * Time.deltaTime * newspeed, Space.World);
        }


        /*
        //This gets the axis (direction) we want to go
        float xDirection = Input.GetAxis("Horizontal");
        float zDirection = Input.GetAxis("Vertical");

        //This tells us which way we're going to go
        Vector3 moveDirecton = new Vector3(xDirection, 0.0f, zDirection);
        //Make sure to add deltaTime because if not passes thru objects (limits to seconds instead of using computer speed)
        transform.position += moveDirecton * speed * Time.deltaTime;
        */
    }
}
