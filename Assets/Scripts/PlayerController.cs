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
    [SerializeField]
    float changeLimit;
    float changeTime;
    bool isChangeWeapon;

    WeaponController weaponController;

    void Start()
    {
        isChangeWeapon = false;
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
        //Zキーで武器変更
        if (Input.GetKeyDown(KeyCode.Z))
        {
            weaponPrefab = tripleShot;
            isChangeWeapon = true;
        }

        if (isChangeWeapon)
        {
            changeTime += Time.deltaTime;
        }
        if (changeLimit <= changeTime)
        {
            weaponPrefab = normalShot;
            changeTime = 0;
            isChangeWeapon = false;
        }
    }

    //プレイヤーの移動制限
    void Clamp()
    {
        Vector2 playerPos = transform.position;
        playerPos.x = Mathf.Clamp(playerPos.x, -6f, 6f);
        transform.position = new Vector2(playerPos.x, playerPos.y);
    }
}
