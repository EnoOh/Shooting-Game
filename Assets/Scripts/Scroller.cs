using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scroller : MonoBehaviour {

	void Start () {
		
	}

    private void FixedUpdate() {
        transform.Translate(0, -0.3f, 0);
        if (transform.position.y < -10.6f)
        {
            transform.position = new Vector3(0, 10.6f, 0);
        }
    }

    void Update () {
        
	}
}
