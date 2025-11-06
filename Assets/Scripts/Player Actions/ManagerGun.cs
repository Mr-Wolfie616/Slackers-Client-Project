using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ManagerGun : MonoBehaviour
{
    [SerializeField] private LayerMask layerMask;
    [SerializeField] private Transform Camera;
    private HealthManagement AlienScript;
    private CPUBehaviour NpcScript;

    void FixedUpdate()
    {
        RaycastHit hit;

        if (Physics.Raycast(Camera.transform.position, Camera.transform.TransformDirection(Vector3.forward), out hit, Mathf.Infinity, layerMask))
        {
            Debug.DrawRay(Camera.transform.position, Camera.transform.TransformDirection(Vector3.forward) * 1000, Color.white);
            Debug.Log(hit.collider.gameObject.name);
            if (hit.transform.TryGetComponent(out AlienScript))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.DrawRay(Camera.transform.position, Camera.transform.TransformDirection(Vector3.forward) * 1000, Color.yellow);
                    AlienScript.Damage();
                    Debug.Log("HAHAHA");
                }
            }

            if (hit.transform.TryGetComponent(out NpcScript))
            {
                if (Input.GetMouseButtonDown(0))
                {
                    Debug.DrawRay(Camera.transform.position, Camera.transform.TransformDirection(Vector3.forward) * 1000, Color.red);
                    Debug.Log("NOOOOOOO");
                }
            }

        }

    }
}
