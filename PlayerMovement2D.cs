﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    public int speed;
    public SpriteRenderer sr;
    public Rigidbody2D rb;
    public float jumpForce;
    bool isGrounded;
    //public Animator anim;
    //bool shotTimer;
    //float shotTime = 0.2f;
    //public GameObject bulletPrefab;
    public Transform positionLeft;
    public Transform positionRight;
    //public int shotSpeed;
    //bool fire;
    // Start is called before the first frame update
    void Start()
    {
        isGrounded = true;
        //shotTimer = false;
        //fire = true;
    }

    // Update is called once per frame
    void Update()
    {
        /*if (shotTimer)
        {
            shotTime -= Time.deltaTime;
        }
        if (shotTime <= 0)
        {
            shotTimer = false;
            anim.SetBool("isShooting", false);
            shotTime = .2f;
        }*/
        movement();
    }

    public void movement()
    {
        /*if (Input.GetMouseButton(0))
        {
            if (!shotTimer)
            {
                if (!sr.flipX && fire)
                {
                    GameObject bullet = Instantiate(bulletPrefab, positionLeft.position, Quaternion.identity);
                    bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * -shotSpeed;
                }
                else if (fire)
                {
                    GameObject bullet = Instantiate(bulletPrefab, positionRight.position, Quaternion.identity);
                    bullet.GetComponent<Rigidbody2D>().velocity = Vector2.right * shotSpeed;
                }
                anim.SetBool("isShooting", true);
                shotTimer = true;
            }
        }*/
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //anim.SetBool("isFalling", true);
            if (isGrounded)
            {
                //anim.SetBool("isShooting", false);
                rb.AddForce(Vector2.up * jumpForce);
                isGrounded = false;
                //fire = false;
            }
        }
        if (Input.GetKey(KeyCode.D))
        {
            //anim.SetBool("isWalking", true);
            //anim.SetBool("isShooting", false);
            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));
            sr.flipX = true;
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //anim.SetBool("isWalking", true);
            //anim.SetBool("isShooting", false);
            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
            sr.flipX = false;
        }
        //else
           //anim.SetBool("isWalking", false);
    }

    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGrounded = true;
            //fire = true;
            //anim.SetBool("isFalling", false);
        }

    }
}
