using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

	// Use this for initialization
	void Start () {

        PhotonNetwork.Instantiate("Cube", new Vector3(0, 0, 0), Quaternion.identity, 0);
		
	}
	
	// Update is called once per frame
	void Update () {
        if(Input.GetKey(KeyCode.D)){
            gameObject.transform.Translate(Vector3.right * 15f * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.W))
        {
            gameObject.transform.Translate(Vector3.forward * 15f * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.S))
        {
            gameObject.transform.Translate(Vector3.back * 15f * Time.deltaTime, Space.World);
        }
        if (Input.GetKey(KeyCode.A))
        {
            gameObject.transform.Translate(Vector3.left * 15f * Time.deltaTime, Space.World);
        }
		
	}
}
