using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using UnityEngine;

public class TaskInteraction : MonoBehaviour
{
    // Small Task
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
    private GameObject hitObject;
    private GameObject startChild;
    private GameObject endChild;
    private float range = 2f;
    public Transform parent;

    void Awake()
    {
        
    }
    
    void FixedUpdate()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, layerMask = LayerMask.GetMask("Stask")))

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
// Large task
    // Shoot ray from camera
    //   set origin to camera 
    // when ray hit task tell player to interact 
    // when interacted lift task up
    // when lifted task hits stationary task complete task

        else if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, layerMask = LayerMask.GetMask("Ltask")))
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.red);
            Debug.Log("Press E");

            if (Input.GetKey(KeyCode.E))
            {
                hitObject = hit.collider.gameObject;
                hitObject.transform.parent = parent;
                
                Debug.Log("Key Pressed");
            }
        }

        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }

    }
}
