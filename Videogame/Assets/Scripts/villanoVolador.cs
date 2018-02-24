 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class villanoVolador : MonoBehaviour {

	// Use this for initialization
	void Start () {
		StartCoroutine (matar());
	}
	
	// Update is called once per frame
	void Update () {
		transform.Translate(-2 * Time.deltaTime, 0, 0);

	}

	IEnumerator matar(){
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
	}
}
