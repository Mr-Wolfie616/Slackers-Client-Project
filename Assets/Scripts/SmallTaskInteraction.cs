using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallTaskInteraction : MonoBehaviour
{
    // Shoot ray from camera
    //   set origin to camera 
    // when ray hit task tell player to interact 
    // when player interacts with task change its state
    //   Store Objects new state 
    //   store Objects current state
    //   when looking at task and press e it will change 
    //       delete old state 
    //       instantiate new state

    LayerMask layerMask;
    public GameObject hitObject;
    public GameObject startChild;
    public GameObject endChild;

    void Awake()
    {
        layerMask = LayerMask.GetMask("Stask", "");
    }
    
    void FixedUpdate()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, 1.5f, layerMask))

        { 
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
            Debug.Log("Press E");
            hitObject = hit.collider.gameObject;
            startChild = hitObject.transform.GetChild(0).gameObject;
            endChild = hitObject.transform.GetChild(1).gameObject;
            Debug.Log("startChild: " + startChild.name);
            Debug.Log("endChild: " + endChild.name);
            Debug.Log("Hit object: " + hitObject.name);
            
            if (Input.GetKey(KeyCode.E))
            {
                startChild.SetActive(false);
                endChild.SetActive(true);
            }
        }
        else
        { 
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white); 
            Debug.Log("Did not Hit"); 
        }

    }
}
