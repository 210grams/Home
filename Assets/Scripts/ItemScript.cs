using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour {

    public GameObject player;
    public Player_Interact piScript;
    public GameObject playerHolding;
    public string placedObject;
	// Use this for initialization
	void Start () {
        piScript = player.GetComponent<Player_Interact>();
        
    }
	
	// Update is called once per frame
	void Update () {        
        placedObject = piScript.placedObject;   
        if ( placedObject == "Kid's Drawing")
        {
            //play kids drawing music
        }
        else if (placedObject == "Family Photo")
        {
            //play family photo music
        }
        else if (placedObject == "Calendar")
        {
            //play calendar music
        }


        if (placedObject == "Console")
        {
            //play console music
        }
        else if (placedObject == "Music Box")
        {
            //play music box music
        }
        else if (placedObject == "Boardgame")
        {
            //play boardgame music
        }


        if (placedObject == "Instrument")
        {
            //play instrument music
        }
        else if (placedObject == "Rocket")
        {
            //play rocket music
        }
        else if (placedObject == "Skateboard")
        {
            //play skateboard music
        }
    }
}
