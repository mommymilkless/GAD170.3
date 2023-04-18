using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTime : MonoBehaviour
{
    // THIS SCRIPT NEEDS
    /*
        To trigger tutorial pop-ups - call to the canvas manager lolol
        {

        }

        To trigger a vignette of some sort to indicate to the player they've been spotted on trigger stay - canvas manager
        {

        }

        An area that triggers the ability to use a something/press a button (this will be the hat shop analogy) - game controller
        {

        }
    */

    // Called when you first enter a trigger volume
    void OnTriggerEnter(Collider collision)
    {
        // Display tutorial pop-ups
        if(collision.gameObject.tag=="Player")
        {
            // If statement to check if the thing the player is colliding with is the tutorial zone or the cat at the end
            // Call to canvas manager for tutorial pop-ups
        }
    }

    // Called while you're inside the trigger volume
    void OnTriggerStay(Collider collision)
    {
        // Losing obscurity while inside the trigger volume
        if(collision.gameObject.tag=="Player")
        {
            // Lose obscurity
            // Call to the canvas manager to trigger vignette thingy
        }

        // Vignette is on screen - maybe gets more intense??
        
        // ability to use the hats

        // ability to consult with the overlord
        
        
        // From Week 9 code
        /*
        if(collision.gameObject.name=="Player")
        {
            Debug.Log("Wowee");
        }
        else
        {
            Debug.Log("You are not the player. Die");
            collision.gameObject.GetComponent<Rigidbody>().AddForce(collision.gameObject.transform.up*100);
        }
        */
    }
}
