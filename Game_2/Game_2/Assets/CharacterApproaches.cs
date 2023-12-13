using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterApproaches : MonoBehaviour
{
    ButterlyControl mainChar;
    private bool isChasing = false;

    float MinValue = 3, speed = 1;

    // Start is called before the first frame update
    void Start()
    {
        mainChar = FindAnyObjectByType<ButterlyControl>();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isClose(mainChar,this))
        {
            isChasing = true;
        }

        if (isChasing)
        {
            Vector3 lookatVec = new Vector3(mainChar.transform.position.x, transform.position.y, mainChar.transform.position.z);
            transform.LookAt(lookatVec);
            transform.position += speed * transform.forward * Time.deltaTime;
        }
    }

    private bool isClose(ButterlyControl mainChar, CharacterApproaches thisDeer)
    {
        return Vector3.Distance(mainChar.transform.position, thisDeer.transform.position) < 5;
    }
}
