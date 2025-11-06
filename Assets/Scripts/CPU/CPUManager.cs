using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CPUManager : MonoBehaviour
{
    public GameObject CPUPrefab;
    public int NumberOfCPUs;
    // Start is called before the first frame update
    void Start()
    {
        GenerateCPUs();
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void GenerateCPUs()
    {
        for (int i = 0; i < NumberOfCPUs; i++)
        {
            Instantiate(CPUPrefab);
        }
    }
}
