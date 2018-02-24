using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawn : MonoBehaviour {

	public GameObject villano;


	void Start () {
		StartCoroutine (Corrutina ());
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator Corrutina(){
		while (true) {
			yield return new WaitForSeconds (1);
			Instantiate (villano,new Vector2(transform.position.x, transform.position.y), Quaternion.identity);
		}
	}
		
}
