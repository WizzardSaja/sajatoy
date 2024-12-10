using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KineticSculpture : MonoBehaviour
{
    public float speed = 2f; // سرعة الحركة
    public float height = 2f; // مدى الحركة الرأسية
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        foreach (Transform child in transform)
        {
            float offset = child.GetSiblingIndex() * 0.5f;
            child.position = new Vector3(
                child.position.x,
                Mathf.Sin(Time.time * speed + offset) * height,
                child.position.z);
        }
    }
    //  for (int i = 0; i < transform.childCount; i++)
    //   {
    //            Transform child = transform.GetChild(i); // 
    //       float offset = i * 0.5f; // فارق زمني بين الكرات
    //       child.position += Vector3.up * Mathf.Sin(Time.time * speed + offset) * height * Time.deltaTime;
    //   }
    //  }
    //}
}
