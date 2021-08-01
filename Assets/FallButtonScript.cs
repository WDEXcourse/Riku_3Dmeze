using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallButtonScript : MonoBehaviour
{
public GameObject[] leaves;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0;i < leaves.Length; i++)
        {
            leaves[i].SetActive(false);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            for (int i = 0; i < leaves.Length; i++)
            {
                leaves[i].SetActive(true);
            }
        }
    }


}

