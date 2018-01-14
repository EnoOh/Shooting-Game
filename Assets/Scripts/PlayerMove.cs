using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    void Start()
    {

    }

    void Update()
    {
       if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPos = touch.position;
            touchPos.z = 10.0f;
            touchPos = Camera.main.ScreenToWorldPoint(touchPos);
            transform.position = touchPos;
        }
    }
}
