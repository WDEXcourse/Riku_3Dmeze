using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float countTime = 300;
    public Image timeimeage;


    // Use this for initialization
    void Start()
    {
        timeimeage.color = Color.green;
    }

    // Update is called once per frame
    void Update()
    {


        countTime -= Time.deltaTime;


        GetComponent<Text>().text = countTime.ToString("F0");

        timeimeage.fillAmount = countTime/300;

        if (countTime < 30)
        {
            timeimeage.color = Color.red;
        }
        else if (countTime < 150)
        {
            timeimeage.color = Color.yellow;
        }


    }
}
