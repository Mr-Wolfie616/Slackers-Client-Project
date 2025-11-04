using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabble : MonoBehaviour
{
    private Rigidbody rb;
    private Transform GrabPointAnchorTransform;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Grab(Transform GrabPointAnchorTransform)
    {
        this.GrabPointAnchorTransform = GrabPointAnchorTransform;
        rb.useGravity = false;
    }

    public void Collide()
    {
        // if collider collides with parent object for 20 secs get component changeable and run it. 
        //check for collison 
        // check for components
        // run Script on parent
    }

    public void Drop()
    {
        this.GrabPointAnchorTransform = null;
        rb.useGravity = true;
    }
    private void FixedUpdate()
    {
        if (GrabPointAnchorTransform != null)
        {
            float lerpSpeed = 10f;
            Vector3 newPosition = Vector3.Lerp(transform.position, GrabPointAnchorTransform.position, Time.deltaTime * lerpSpeed);
            rb.MovePosition(newPosition);
        }
    }
}
