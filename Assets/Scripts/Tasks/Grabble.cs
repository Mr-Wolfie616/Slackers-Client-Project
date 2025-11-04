using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Grabble : MonoBehaviour
{
    private Rigidbody rb;
    private Transform GrabPointAnchorTransform;
    private Changeable ObjectChangeable;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }
    public void Grab(Transform GrabPointAnchorTransform)
    {
        this.GrabPointAnchorTransform = GrabPointAnchorTransform;
        rb.useGravity = false;
    }

    void OnCollisionStay(Collision collision)
    {
        if (rb.useGravity == false)
        {
            if (collision.gameObject == transform.parent?.gameObject)
            {
                ParentCollision();
            }

        }
    }
    
    public void ParentCollision()
    {
        transform.parent.TryGetComponent(out ObjectChangeable);
        ObjectChangeable.Change();
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
