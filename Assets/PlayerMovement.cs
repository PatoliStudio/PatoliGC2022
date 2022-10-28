using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] Rigidbody rb;
    [SerializeField] float speed = 2f;
    [SerializeField] float jumpForce = 250f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector3.right * speed);
        }
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * speed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            rb.AddForce(-Vector3.forward * speed);
        }

        // if (Input.GetKeyDown(KeyCode.Space))
        // {
        //     rb.AddForce(Vector3.up * jumpForce);
        // }
    }
}
