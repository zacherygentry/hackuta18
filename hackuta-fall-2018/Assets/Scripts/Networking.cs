using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Networking : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PhotonNetwork.ConnectUsingSettings("");
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
