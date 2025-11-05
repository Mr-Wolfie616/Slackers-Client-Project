using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CPUBehaviour : MonoBehaviour
{
    public List<CPUJobs> AllJobs;
    
    private List<CPUJobs> CurrentJobs;
    private CPUJobs currentJob;
    // Start is called before the first frame update
    void Start()
    {
        RestockJobs();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    void RestockJobs()
    {
        foreach (CPUJobs Job in AllJobs)
        {
            CurrentJobs.Add(Job);
        }
    }

    void Movement()
    {
        transform.LookAt(new Vector3(currentJob.Location.x, transform.position.y, currentJob.Location.z));
        transform.position += transform.forward * Time.deltaTime;
    }
}
