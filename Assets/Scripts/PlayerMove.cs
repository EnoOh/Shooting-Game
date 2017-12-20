using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {
    float direction = 0f;
    public float speed = 10f;
    Rigidbody2D rb2d;
    Vector3 playerPos;

	void Start () {
        rb2d = GetComponent<Rigidbody2D>();
	}
	
	void Update () {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            direction = 1f;
        }else if (Input.GetKey(KeyCode.LeftArrow))
        {
            direction = -1f;
        }
        else
        {
            direction = 0f;
        }
        rb2d.velocity = new Vector2(speed * direction, rb2d.velocity.y);      
	}
}
