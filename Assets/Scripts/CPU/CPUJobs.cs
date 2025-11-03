using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "CPU Job", fileName = "New CPU Job")]
public class CPUJobs : ScriptableObject
{
    public Vector3 Location;
    public float JobLengthInSeconds;
    public float Priority;
}
