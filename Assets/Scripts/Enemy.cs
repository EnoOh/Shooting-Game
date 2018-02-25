using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    EnemyBase enemyBase;
	
	void Start () {
        enemyBase = GetComponent<EnemyBase>();
        enemyBase.Move(transform.right * -1);
	}
	
	void Update () {
		
	}

    private void OnTriggerEnter2D(Collider2D c)
    {
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        if (layerName != "Bullet") return;
        Destroy(c.gameObject);
        Destroy(gameObject);
    }
}
