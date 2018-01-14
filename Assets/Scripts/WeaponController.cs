using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponController : MonoBehaviour {

    public int speed = 10;
	
	void Start () {
        GetComponent<Rigidbody2D>().velocity = transform.up.normalized * speed;
	}
	
	void Update () {
		
	}
}
