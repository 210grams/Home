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
<<<<<<< HEAD
<<<<<<< HEAD

    public GameObject itemSpawnPoint;
    public GameObject deactivatedItem;
	// Use this for initialization

    void Start () {
       

    }
    
=======
    // Use this for initialization
=======
    // Use this for initialization

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        RaycastHit hit;
>>>>>>> aac495053fe851faa18159801bdcff06a3701084

    void Start()
    {

    }

>>>>>>> a020259400c8622301b7ed87e7f1f0c72420be7b
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
<<<<<<< HEAD
<<<<<<< HEAD
        if (objectHeld && Input.GetMouseButtonDown(1))
        {

            deactivatedItem.SetActive(true);
            Destroy(heldObj);
            objectHeld = false;
        }
        if (objectHeld)
            {
                Debug.Log("2nd If");
                
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 3.5f) && hit.transform.tag == "TargetSlot")
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
=======
        if (objectHeld)
        {
            Debug.Log("2nd If");

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100) && hit.transform.tag == "TargetSlot")
            {

                //Placement tooltip
                if (Input.GetKeyDown(KeyCode.E))
                {
=======
        if (objectHeld)
        {
            Debug.Log("2nd If");

            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 100) && hit.transform.tag == "TargetSlot")
            {

                //Placement tooltip
                if (Input.GetKeyDown(KeyCode.E))
                {
>>>>>>> aac495053fe851faa18159801bdcff06a3701084
                    targetSlot = hit.transform.gameObject;
                    Destroy(heldObj);

                    targetSlotTransform = targetSlot.transform;
                    placeObject = Instantiate(Resources.Load(heldObjString, typeof(GameObject)), targetSlotTransform) as GameObject;
                    objectHeld = false;
<<<<<<< HEAD
>>>>>>> a020259400c8622301b7ed87e7f1f0c72420be7b
=======
>>>>>>> aac495053fe851faa18159801bdcff06a3701084
                }
            }
        }


<<<<<<< HEAD
<<<<<<< HEAD
        
=======
    }

}
>>>>>>> a020259400c8622301b7ed87e7f1f0c72420be7b
=======
    }

}
>>>>>>> aac495053fe851faa18159801bdcff06a3701084
