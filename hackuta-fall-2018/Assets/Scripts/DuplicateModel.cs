using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DuplicateModel : MonoBehaviour {

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   
    public void Duplicate(GameObject prefab){
        GameObject gameObject = Instantiate(prefab, transform);
    }
}
