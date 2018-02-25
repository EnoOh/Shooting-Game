using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    EnemyBase enemyBase;
    [SerializeField]
    int hp;
	
	void Start () {
        enemyBase = GetComponent<EnemyBase>();
        enemyBase.Move(transform.right * -1);
	}
	
	void Update () {
		if(hp <= 0)
        {
            Destroy(gameObject);
        }
	}

    private void OnTriggerEnter2D(Collider2D c)
    {
        hp--;
        string layerName = LayerMask.LayerToName(c.gameObject.layer);
        if (layerName != "Bullet") return;
        Destroy(c.gameObject);
    }
}
