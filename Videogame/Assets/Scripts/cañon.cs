using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour {

	public GameObject bala;

	// Use this for initialization
	void Start () {
		StartCoroutine (Corrutina ());
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	IEnumerator Corrutina(){
		while (true) {
			yield return new WaitForSeconds (1);
			Instantiate (bala,new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
		}
	}
}
