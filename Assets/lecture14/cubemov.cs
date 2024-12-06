using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubemov : MonoBehaviour
{
    public float speed = 2;
    void Start()
    {

    }

    void Update()
    {
        //transform.position+=new Vector3(0.1f*Time.deltaTime,0,0); 
        // transform.position += new Vector3(speed *Time.smoothDeltaTime,0,0);
        float ynew = Mathf.Sin(Time.time);
        float xnew = Mathf.PingPong(Time.time * 10, 10) - 5;
        transform.position += new Vector3(transform.position.x, ynew * Time.deltaTime * 4f, transform.position.z);
        transform.rotation = Quaternion.Euler(new Vector3(transform.position.x, ynew * Time.deltaTime * 45f, transform.position.z));
        transform.localScale = Vector3.one * ynew / 4 + new Vector3(3, 3, 3); // بخلي المكعب يتنفس عشان هيك قسمت ع اربعة 
        Debug.Log(xnew);                                                                      // لو بدي اسرعه بضرب التايم عشان اسرع الوقت و بضل نفس التاثير اووك؟؟؟؟؟؟
        transform.position = new Vector3(xnew, transform.position.y, transform.position.z);


    }
}
