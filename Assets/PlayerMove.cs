﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    bool isGround;
    string item;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
    }
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("up"))
        {

            transform.position += transform.forward * 0.1f;

        }

        if (Input.GetKey("right"))
        {
            transform.Rotate(0, 5, 0);
        }

        if (Input.GetKey ("left")) //Input.GetKey (KeyCode.LeftArrow)
        {
            transform.Rotate(0, -5, 0);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGround == true)
            {
                isGround = false;
                rb.AddForce(0, 5, 0, ForceMode.Impulse);
            }
            
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Ground")
        {
            isGround = true;
        }
        if (collision.gameObject.tag == "rubbish")
        {
            item = collision.gameObject.name;
            print(item);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "GarbageCan")
        {
            if (collision.gameObject.name == item)
            {
                print("ok");
                item = "";
            }
            
        }
    }
}
