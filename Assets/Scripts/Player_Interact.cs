using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Interact : MonoBehaviour {

    public bool objectHeld;
    public GameObject heldObj;
    public string heldObjString;
    public GameObject objectHolder;
    public Transform objHolderTransform;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (!objectHeld)
        {
            RaycastHit hit;
            if(Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity) && hit.transform.tag == "Item")
            {
                //PickUp tooltip
                if (Input.GetKeyDown("E"))
                {
                    heldObj = hit.transform.gameObject;
                    Destroy(hit.transform.gameObject);
                    heldObjString = heldObj.transform.name;
                    heldObj = (GameObject)Instantiate(Resources.Load(heldObjString), objHolderTransform.parent);
                }
            }

        }
	}
}
