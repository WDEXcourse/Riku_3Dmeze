using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorMove : MonoBehaviour
{
    public float speed;

    public float radius;

    float angle = 0;

    Vector3 pos;
    Vector3 start;
    // Start is called before the first frame update
    void Start()
    {
        pos = this.transform.position;
        start = pos;
    }

    // Update is called once per frame
    void Update()
    {
        pos.x = radius * Mathf.Sin(angle);
        pos.x += start.x;
        angle += speed;

        this.transform.position = pos;
    }
}
