using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    private float speed = 0.3f;
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
            float x = touch.deltaPosition.x;
            float y = touch.deltaPosition.y;
            Vector2 direction = new Vector2(x, y);
            Move(direction);
        }
    }

    void Move(Vector2 direction)
    {
        //画面左下のビューポート座標取得
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        //画面右上のビューポート座標取得
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        Vector2 playerPos = transform.position;
        playerPos += direction * speed * Time.deltaTime;

        //移動制限
        playerPos.x = Mathf.Clamp(playerPos.x, min.x, max.x);
        playerPos.y = Mathf.Clamp(playerPos.y, min.y, max.y);

        transform.position = playerPos;
    }
}
