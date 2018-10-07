using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableVR : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        #if UNITY_IOS
                gameObject.SetActive(false);
        #endif
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
