using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Jobs;
using UnityEngine;
using UnityEngine.AI;

public class CPUBehaviour : MonoBehaviour
{
    public List<CPUJobs> AllJobs;
    public NavMeshAgent Agent;
    private List<CPUJobs> CurrentJobs;
    private float currentJobTime = 0;
    // Start is called before the first frame update
    void Start()
    {
        CurrentJobs = new List<CPUJobs>();
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
        Vector3 pos = new Vector3(CurrentJobs[0].Location.x, transform.position.y, CurrentJobs[0].Location.z);

        if ((transform.position - pos).magnitude > 1)
        {
            Agent.SetDestination(pos);
            currentJobTime = CurrentJobs[0].JobLengthInSeconds;
        }
        else
        {
            if (currentJobTime > 0) currentJobTime -= Time.deltaTime;
            else CurrentJobs.RemoveAt(0);
        }

        if (CurrentJobs.Count < 1)RestockJobs();
    }
}
