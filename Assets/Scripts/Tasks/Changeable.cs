using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changeable : MonoBehaviour
{
    private GameObject startChild;
    private GameObject endChild;

    void Awake()
    {
        startChild = this.transform.GetChild(0).gameObject;
        endChild = this.transform.GetChild(1).gameObject;
    }


    public void Change()
    {
        startChild.SetActive(false);
        endChild.SetActive(true);
    }
}
