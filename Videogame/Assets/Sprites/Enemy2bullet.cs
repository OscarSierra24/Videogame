using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2bullet : MonoBehaviour {

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 2);
    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(
            transform.right * Time.deltaTime * -1
        );
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        print("c");
        Destroy(collision.gameObject);
    }
}
