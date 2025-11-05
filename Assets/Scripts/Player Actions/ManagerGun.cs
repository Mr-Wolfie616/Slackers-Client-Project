using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManagerGun : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform Camera;
    private TaskInteraction AlienScript;
    private CPUBehaviour NpcScript;

    void FixedUpdate()
    {
        RaycastHit hit;

        if(Physics.Raycast(Camera.transform.position,Camera.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.Log(hit.collider.gameObject.name);
            if (hit.transform.TryGetComponent(out AlienScript))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Debug.Log("HAHAHA");
                }
            }

            if (hit.transform.TryGetComponent(out NpcScript))
            {
                if (Input.GetKey(KeyCode.Mouse0))
                {
                    Debug.Log("NOOOOOOO");
                }
            }
            
        }

    }

}
