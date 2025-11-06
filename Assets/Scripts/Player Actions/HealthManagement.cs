using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthManagement : MonoBehaviour
{
    // store health 
    // damage health
    // end game or stop player moving when health is 0

    public float health;
    private GameObject NewParent;

    void Awake()
    {
        NewParent = transform.parent.gameObject;
    }

    void Update()
    {
        if (health <= 0f)
        {
            health = 0;
            NewParent.SetActive(false);
        }
    }

    public void Damage()
    {
        health -= 1f;
    }
}
