using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    [SerializeField]
    float weaponSpeed;
	
	void Start () {
        
	}
	
	void Update () {
        transform.Translate(0, weaponSpeed, 0);
		if(transform.position.y > 5.0f)
        {
            //弾が上端まで来たら弾を消滅させる
            Destroy(gameObject);
        }
	}   
}
