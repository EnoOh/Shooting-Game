using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    GameObject weapon;

    WeaponController weaponController;

    void Start()
    {

    }

    void Update() {
        //左右キーでプレイヤーの移動
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-0.1f, 0, 0);
            Clamp();
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(0.1f, 0, 0);
            Clamp();
        }

        //スペースキーで弾を撃つ
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(weapon, transform.position, Quaternion.identity);
            weapon.transform.Translate(0, 0.2f, 0);
        }
    }

    //プレイヤーの移動制限
    void Clamp()
    {
        Vector2 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -4.5f, 4.5f);
        transform.position = new Vector2(playerPos.x, playerPos.y);
    }
}
