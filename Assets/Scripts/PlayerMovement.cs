using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody rigidbody;
    [SerializeField] float movementSpeed = 5f;
    [SerializeField] float jumpForce = 5f;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("w"))
        {
            rigidbody.velocity = new Vector3(0, 0, 5f);
        }
        if (Input.GetKey("s"))
        {
            rigidbody.velocity = new Vector3(0, 0, -5f);
        }


        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        //rigidbody.velocity = new Vector3(horizontalInput * movementSpeed, rigidbody.velocity.y, verticalInput * movementSpeed);
        transform.Rotate(new Vector3(Mathf.Clamp(-verticalInput, -20, 50), 0, -horizontalInput));
        //if (Input.GetKey("up"))
        //{
        //    transform.Rotate(new Vector3(-1f, 0, 0));
        //}
        //if (Input.GetKey("down"))
        //{
        //    transform.Rotate(new Vector3(1f, 0, 0));
        //}

    }
}
