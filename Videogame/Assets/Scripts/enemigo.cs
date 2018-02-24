using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey (KeyCode.A)){
			transform.Translate(-2 * Time.deltaTime, 0, 0);

		}
		else if(Input.GetKey (KeyCode.D)){
			transform.Translate(2 * Time.deltaTime, 0, 0);

		}
	}
}
