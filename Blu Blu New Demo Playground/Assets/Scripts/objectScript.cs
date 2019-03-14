using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectScript : MonoBehaviour {
	public float speed = 0.5f;

	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = Vector3.down * speed;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnBecameInvisible(){
		Destroy (gameObject);
	}
}
