using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;
namespace lecture15
{
    public class camraex : MonoBehaviour
    {
        // Start is called before the first frame update
        float speed = 3f;
        void Start()
        {
          Camera.main.backgroundColor = Color.red;
        }

        // Update is called once per frame
        void Update()
        {
            if (Input.GetMouseButton(0)) // زيرو يعني الزر الشمال
            {
                Vector3 mousePosition = Input.mousePosition;
                mousePosition.z = 10;
                Vector3 InUnityPosition = Camera.main.ScreenToWorldPoint(mousePosition);
                transform.position = Vector3.Lerp(transform.position, InUnityPosition, speed * Time.deltaTime);

                //transform.position = InUnityPosition;
                //Debug.Log("" + mousePosition);
            }
        }
    }
}