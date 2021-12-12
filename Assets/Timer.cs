using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    float countTime;
    public Image timeimeage;
    public float limitTime = 300;

    // Use this for initialization
    void Start()
    {
        timeimeage.color = Color.green;

        countTime = limitTime;
    }

    // Update is called once per frame
    void Update()
    {


        countTime -= Time.deltaTime;


        GetComponent<Text>().text = countTime.ToString("F0");

        timeimeage.fillAmount = countTime/limitTime;

        if (timeimeage.fillAmount < 0.1f)
        {
            timeimeage.color = Color.red;
        }
        else if (timeimeage.fillAmount < 0.5f)
        {
            timeimeage.color = Color.yellow;
        }


    }
}
