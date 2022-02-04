using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class look : MonoBehaviour
{

    public float mouseSensitivity = 100f;

    public Transform playerbody;

    private float xRotaion = 0f;

    //COROUTINE BREAK COMPUTER
    //BREAK
    //COMPUTER
    // BREAK
    //COMPUTER 


    
    
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float mousex = Input.GetAxis("GetMouse X")*mouseSensitivity*Time.deltaTime;
        
        float mousey = Input.GetAxis("GetMouse Y") * mouseSensitivity * Time.deltaTime;

       xRotaion -= mousey;

        playerbody.Rotate(Vector3.up*mousex);

        transform.localRotation = Quaternion.Euler(xRotaion,                                                                                                        0,                                          0f);

        xRotaion = Mathf.Clamp(xRotaion, -90, 90f);

    }
}
