﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ButtonScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void LoadMain(){
		SceneManager.LoadScene ("MainScene");
	}

	public void Quit(){
		Application.Quit ();
	}
	public void RestartGame(){
		SceneManager.LoadScene ("MainScene");
	}
}
