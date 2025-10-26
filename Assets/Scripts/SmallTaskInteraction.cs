using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallTaskInteraction : MonoBehaviour
{
   // Shoot ray from camera
   //   set origin to camera 
   // when ray hit task tell player to interact 
   // when player interacts with task change its state

    LayerMask layerMask;

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
            Debug.Log("Did Hit");
            
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("E");
            }
        }
        else
        { 
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * 1000, Color.white); 
            Debug.Log("Did not Hit"); 
        }

    }
}
