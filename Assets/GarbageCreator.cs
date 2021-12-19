using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCreator : MonoBehaviour
{
    public GameObject[] Garbages;
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Garbages[0], this.transform.position,Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
