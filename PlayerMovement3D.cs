using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement3D : MonoBehaviour
{
    [SerializeField] float speed = 20f;
    [SerializeField] float jumpForce = 20f;
    bool isGrounded;

    public Rigidbody rb;
    void Start()
    {
        rb =  gameObject.GetComponent<Rigidbody>();
        isGrounded = true;
    }

    void Update()
    {
        Movement();
    }

    private void Movement()
    {
        Vector3 pos = transform.position;

        /*if (Input.GetKey("w"))
        {
            pos.z += speed * Time.deltaTime;
        }*/
        /*if (Input.GetKey("s"))
        {
            pos.z -= speed * Time.deltaTime;
        }*/
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                Debug.Log("JUMP!!");
                rb.AddForce(new Vector3(0,20f,0) * jumpForce);
                isGrounded = false;
            }
        }

        transform.position = pos;
    }

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
        }
    }
}
