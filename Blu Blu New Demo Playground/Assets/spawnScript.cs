using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnScript : MonoBehaviour {
	public GameObject Triangle;
	public GameObject Square;
	public GameObject Circle;
	public int x;

	public float spawnTime = 4;
	// Use this for initialization
	void Start () {
		//System.Diagnostics.Process.Start ("gameDemo.py"); //added
		x = Random.Range(1, 9);
		InvokeRepeating ("addObject", 0, spawnTime); 
	}

	// Update is called once per frame
	void Update () {
		x = Random.Range(1, 9);
	}
	void addObject() {
		float x1 = transform.position.x - GetComponent<Renderer> ().bounds.size.x / 2;
		float x2 = transform.position.x + GetComponent<Renderer> ().bounds.size.x / 2;

		Vector3 spawnPoint = new Vector3 (Random.Range (x1, x2), transform.position.y, transform.position.z);



		//Randomly instantiate triangle/circle/square 
		if (x >= 1 && x <= 2) {
			Instantiate (Triangle, spawnPoint, Quaternion.identity);
		} else if (x > 2 && x <= 4) {
			Instantiate (Circle, spawnPoint, Quaternion.identity);
		} else {
			Instantiate (Square, spawnPoint, Quaternion.identity);
		}
	}
}
