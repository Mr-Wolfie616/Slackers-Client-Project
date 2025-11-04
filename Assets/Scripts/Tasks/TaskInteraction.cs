using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
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
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform GrabPointAnchorTransform;
    private Grabble objectGrabble;
    private Changeable objectChangeable;
    private float range = 2f;

    void FixedUpdate()
    {

        RaycastHit hit;
        // Does the ray intersect any objects excluding the player layer
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, layerMask))
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (hit.transform.TryGetComponent(out objectChangeable))
                {
                    objectChangeable.Change();
                }
            }
        }

         if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out hit, range, layerMask))
        {
            if (Input.GetKey(KeyCode.E))
            {
                if (objectGrabble == null)
                {
                    if (hit.transform.TryGetComponent(out objectGrabble))
                    {
                        objectGrabble.Grab(GrabPointAnchorTransform);
                    }
                }

                else
                {
                    objectGrabble.Drop();
                    objectGrabble = null;
                }
            }
        }


        else
        {
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log("Did not Hit");
        }

    }

}
