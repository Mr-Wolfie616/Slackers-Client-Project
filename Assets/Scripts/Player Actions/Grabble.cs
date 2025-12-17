using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class Grabble : MonoBehaviour
{
    private float CollisionTime = 20f;
    private Rigidbody rb;
    private Transform GrabPointAnchorTransform;
    private Changeable ObjectChangeable;
    private GameObject NewParent;

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
                CollisionTime -= Time.deltaTime;
                Debug.Log("ticking!!!");
                Debug.Log(CollisionTime);
                if (CollisionTime <= 0f)
                {
                    CollisionTime = 0f;
                    ParentCollision();
                    CollisionTime = 20f;
                }
            }
        }
                
    }

    public void ParentCollision()
    {
        NewParent = transform.parent.gameObject;
        NewParent.AddComponent<Changeable>();
        transform.parent.TryGetComponent(out ObjectChangeable);
        ObjectChangeable.Change();
    }

    public void Drop()
    {
        this.GrabPointAnchorTransform = null;
        rb.useGravity = true;
        CollisionTime = 20f;
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
