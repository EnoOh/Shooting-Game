using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public int speed = 10;
	
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
	}
	
	void Update () {
		if(transform.position.y > 5.0f)
        {
            //弾が上端まで来たら弾を消滅させる
            Destroy(gameObject);
        }
	}
}
