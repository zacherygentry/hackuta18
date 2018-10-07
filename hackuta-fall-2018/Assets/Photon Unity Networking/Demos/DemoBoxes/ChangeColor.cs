using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon;

public class ChangeColor : Photon.PunBehaviour {

	bool changeColorCollision = false;

	void OnCollisionEnter(Collision other){
		Debug.Log("A collision occured.");
		changeColorCollision = true;
	}

	void checkColorChange(){
		if(changeColorCollision){
			transform.GetComponent<Renderer>().material.color = Color.yellow;
		}
	}
	
	// Update is called once per frame
	void Update () {
		checkColorChange();	
	}
}