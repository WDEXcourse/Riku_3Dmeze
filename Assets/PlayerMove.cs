using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PlayerMove : MonoBehaviour
{
    bool isGround;
    [SerializeField]
    string item;
    Vector3 startPos;
    public Text popup;
    // Start is called before the first frame update
    void Start()
    {
        isGround = false;
        startPos = transform.position;
        popup.text = "";
    }
    public Rigidbody rb;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {

            transform.position += transform.forward * 0.1f;

        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(0, 5, 0);
        }

        if (Input.GetKey(KeyCode.A)) //Input.GetKey (KeyCode.LeftArrow)
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
        if (collision.gameObject.name == "RollBall")
        {
            transform.position = startPos;
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("Rubbish") && item == "")
        {
            item = collision.gameObject.tag;
            print(item);
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.layer == LayerMask.NameToLayer("GarbageCan"))
        {
            popup.text = "ゴミを捨てますか？";

        }
        if (collision.gameObject.name == "Elevator")
        {
            this.transform.parent = collision.gameObject.transform;
        }

    }
    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("GarbageCan"))
        {
            
            if (Input.GetKeyDown(KeyCode.F))
            {
                if (collision.gameObject.tag == item)
                {
                    popup.text = "ゴミを捨てた!";
                    item = "";
                }
                else if(item == "")
                {
                   
                   
                }
                else
                {
                    popup.text = "捨てられない!";
                }
                
            }

        }
    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("GarbageCan"))
        {
            popup.text = "";
        }
        if (collision.gameObject.name == "Elevator")
        {
            this.transform.parent = null;
        }
    }
}
