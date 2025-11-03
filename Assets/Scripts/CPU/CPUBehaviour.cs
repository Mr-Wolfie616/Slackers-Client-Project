using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class CPUBehaviour : MonoBehaviour
{
    public List<CPUJobs> Jobs;
    private CPUJobs currentJob;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        FindNewJob();
        Movement();
    }

    void FindNewJob()
    {
        float currentJobPriority = 0;

        foreach (CPUJobs Job in Jobs)
        {
            if (Job.Priority > currentJobPriority) {
                currentJobPriority = Job.Priority;
                currentJob = Job;
            }
        }
    }

    void Movement()
    {
        transform.LookAt(new Vector3(currentJob.Location.x, transform.position.y, currentJob.Location.z));
        transform.position += transform.forward * Time.deltaTime;
    }
}
