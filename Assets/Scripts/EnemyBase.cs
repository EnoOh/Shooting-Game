using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class EnemyBase : MonoBehaviour {

    public float enemySpeed;
    public float shotDelay;
    [SerializeField]
    GameObject enemyWeapon;

    protected void Update()
    {
        if(transform.position.y < -6.5f)
        {
            Destroy(gameObject);
        }
    }

    public void Move(Vector3 direction)
    {
        GetComponent<Rigidbody2D>().velocity = direction * enemySpeed;
    }
}
