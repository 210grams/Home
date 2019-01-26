using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player_Interact : MonoBehaviour
{

    public bool objectHeld;
    public GameObject heldObj;
    public string heldObjString;
    public GameObject objectHolder;
    public Transform objHolderTransform;

    public GameObject targetSlot;
    public GameObject placeObject;
    public Transform targetSlotTransform;
    public GameObject itemSpawnPoint;
    public GameObject deactivatedItem;
    public bool itemsMatch = false;
    public string placedObject;
    // Use this for initialization

    void Start()
    {


    }



    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(transform.position, forward, Color.green);
        if (!objectHeld)

        {

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 2) && hit.transform.tag == "Item")
            {

                //PickUp tooltip
                if (Input.GetKeyDown(KeyCode.E))
                {
                    heldObj = hit.transform.gameObject;
                    deactivatedItem = hit.transform.gameObject;
                    hit.transform.gameObject.SetActive(false);
                    heldObjString = heldObj.transform.name;
                    objHolderTransform = objectHolder.transform;

                    heldObj = Instantiate(Resources.Load(heldObjString, typeof(GameObject)), objHolderTransform) as GameObject;
                    heldObj.layer = 2;
                    objectHeld = true;
                }

            }
        }
        if (objectHeld && Input.GetMouseButtonDown(1))
        {

            deactivatedItem.SetActive(true);
            Destroy(heldObj);
            objectHeld = false;
        }
        if (objectHeld)
        {
            
           
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3.5f) && hit.transform.tag == "TargetSlot")
            {
                    if ((heldObjString == "Kid's Drawing" || heldObjString == "Family Photo" || heldObjString == "Calendar") && hit.transform.name == "TargetSlot1")
                    {
                        itemsMatch = true;
                    } else if ((heldObjString == "Console" || heldObjString == "Music Box" || heldObjString == "Boardgame") && hit.transform.name == "TargetSlot2")
                {
                    itemsMatch = true;
                } else if ((heldObjString == "Instrument" || heldObjString == "Rocket" || heldObjString == "Skateboard") && hit.transform.name == "TargetSlot3")
                {
                    itemsMatch = true;
                }
                else
                {
                    itemsMatch = false;
                }

                    //Placement tooltip
                    if (Input.GetKeyDown(KeyCode.E) && itemsMatch)
                {
                    targetSlot = hit.transform.gameObject;
                    Destroy(heldObj);

                    Destroy(placeObject);
                    targetSlotTransform = targetSlot.transform;
                    placeObject = Instantiate(Resources.Load(heldObjString, typeof(GameObject)), targetSlotTransform) as GameObject;
                    objectHeld = false;
                    placedObject = heldObjString;
                }
            }   
        }

    }
}



    



    

