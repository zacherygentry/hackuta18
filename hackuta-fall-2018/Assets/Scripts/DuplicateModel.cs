using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class DuplicateModel : MonoBehaviour {

    public GameObject prefab;
    public bool isDuped = false;
    void Start()
    {
        isDuped = false;
        GetComponent<VRTK_InteractableObject>().InteractableObjectGrabbed += new InteractableObjectEventHandler(ObjectGrabbed);
        GetComponent<VRTK_InteractableObject>().InteractableObjectUngrabbed += new InteractableObjectEventHandler(ObjectUngrabbed);

    }

    private void ObjectGrabbed(object sender, InteractableObjectEventArgs e)
    {
        if (!isDuped)
        {
            Vector3 pos = transform.position;
            GameObject go = Instantiate<GameObject>(prefab, pos, transform.rotation, transform.parent);
            go.GetComponent<VRTK_InteractableObject>().isGrabbable = true;
            GetComponent<Transform>().localScale *= 2f;
            isDuped = true;
        }
    }

    private void ObjectUngrabbed(object sender, InteractableObjectEventArgs e)
    {
       transform.parent = null;
    }
	
	// Update is called once per frame
	void Update () {
	}
}
