using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTime : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider collision)
    {
        
    }

    void OnTriggerStay(Collider collision)
    {
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
