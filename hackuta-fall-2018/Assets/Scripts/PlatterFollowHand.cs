using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatterFollowHand : MonoBehaviour {

    public Transform position;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = position.position;
        transform.rotation = position.rotation;
	}
}
