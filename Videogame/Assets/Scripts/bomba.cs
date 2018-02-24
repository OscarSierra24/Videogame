using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomba : MonoBehaviour {

	private Transform t;
	private GameObject principal;
	private int speed;
	private Vector2 toPosition;


	void Start () {
		speed=2;
		principal = GameObject.Find ("enemigo");
		t =principal.transform;
		toPosition = t.position;
		StartCoroutine (matar());

	}

	void Update () {
		transform.position=Vector2.MoveTowards(new Vector2(transform.position.x, transform.position.y), toPosition, speed* Time.deltaTime);
	}

	void OnCollisionEnter(Collision c){
		Destroy (gameObject);
	}

	IEnumerator matar(){
		yield return new WaitForSeconds (3);
		Destroy (this.gameObject);
	}
}
