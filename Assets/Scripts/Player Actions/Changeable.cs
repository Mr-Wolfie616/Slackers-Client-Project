using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Changeable : MonoBehaviour
{
    private GameObject FirstChild;
    private GameObject SecondChild;
    private GameObject ThirdChild;

    void Awake()
    {
        FirstChild = this.transform.GetChild(0).gameObject;
        SecondChild = this.transform.GetChild(1).gameObject;
    }


    public void Change()
    {
        if (this.transform.childCount > 2)
        {
            ThirdChild = this.transform.GetChild(2).gameObject;
            FirstChild.SetActive(false);
            SecondChild.SetActive(false);
            ThirdChild.SetActive(true);
        }

        else
        {
            FirstChild.SetActive(false);
            SecondChild.SetActive(true);
        }
    }
}
