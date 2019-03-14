using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionScript : MonoBehaviour {

	public float speed = 20;
	private AudioSource audio;
	public int counter = 0;
	public int goal = 5;
	void Start(){
		audio = GetComponent<AudioSource> (); 
	}
	void Update(){
		float moveHorizontal = Input.GetAxisRaw("Horizontal");
		float moveVertical = Input.GetAxisRaw("Vertical");

		Vector3 movement = new Vector3(moveHorizontal, moveVertical, 0f );

		movement = movement * speed * Time.deltaTime;

		transform.position += movement;	}

	void OnCollisionEnter2D(Collision2D col){
		if (col.gameObject.tag == "blue square") {
			audio.Play ();

			Destroy (col.gameObject);

			counter += 1;

			ScoreScript.scoreValue = counter;

			if (counter == goal)
				SceneManager.LoadScene ("EndingMenu");
		}	
	}
}
