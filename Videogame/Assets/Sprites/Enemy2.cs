using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour {

    public GameObject bullet;
    public GameObject pivot;

	// Use this for initialization
	void Start () {
        StartCoroutine(shoot());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    IEnumerator shoot() {
        while (true)
        {
            // always have a wait of some sort
            yield return new WaitForSeconds(1.2f);
            Instantiate(
                bullet,
                pivot.transform.position,
                bullet.transform.rotation
            );
        }
    }


}
