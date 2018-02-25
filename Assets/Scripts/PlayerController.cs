using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    [SerializeField]
    GameObject weaponPrefab;
    [SerializeField]
    GameObject normalShot;
    [SerializeField]
    GameObject tripleShot;

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
            Instantiate(weaponPrefab, transform.position, Quaternion.identity);
            weaponPrefab.transform.Translate(0, 0.2f, 0);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            weaponPrefab = tripleShot;
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
