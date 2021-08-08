using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

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
            rb.AddForce(0, 5, 0,ForceMode.Impulse);
        }
    }
}
