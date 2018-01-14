using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public GameObject weapon;

    IEnumerator Start()
    {
        while (true)
        {
            //弾を生成
            Instantiate(weapon, transform.position, transform.rotation);
            //n秒間隔で
            yield return new WaitForSeconds(0.2f);
        }
    }

    void Update() {
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
