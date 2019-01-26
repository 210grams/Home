using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Interact : MonoBehaviour {

    public bool objectHeld;
    public GameObject heldObj;
    public string heldObjString;
    public GameObject objectHolder;
    public Transform objHolderTransform;
    
    public GameObject targetSlot;
    public GameObject placeObject;
    public Transform targetSlotTransform;
	// Use this for initialization

    void Start () {
		
	}
    
    // Update is called once per frame
    void Update () {
        
        RaycastHit hit;


        if (!objectHeld)

        {

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity) && hit.transform.tag == "Item")
            {
                Debug.Log("1st if");
                //PickUp tooltip
                if (Input.GetKeyDown(KeyCode.E))
                {
                    heldObj = hit.transform.gameObject;
                    Destroy(hit.transform.gameObject);
                    heldObjString = heldObj.transform.name;
                    objHolderTransform = objectHolder.transform;

                    heldObj = Instantiate(Resources.Load(heldObjString, typeof(GameObject)), objHolderTransform) as GameObject;
                    heldObj.layer = 2;
                    objectHeld = true;
                }
            }
        }
            if(objectHeld)
            {
                Debug.Log("2nd If");
                
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100) && hit.transform.tag == "TargetSlot")
                {
                    
                    //Placement tooltip
                    if (Input.GetKeyDown(KeyCode.E))
                    {
                        targetSlot = hit.transform.gameObject;
                        Destroy(heldObj);

                        targetSlotTransform = targetSlot.transform;
                        placeObject = Instantiate(Resources.Load(heldObjString, typeof(GameObject)), targetSlotTransform) as GameObject;
                        objectHeld = false;
                    }
                }
            }

            }
       }
	

