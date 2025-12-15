using System;
using UnityEngine;

public class AnimationModels : MonoBehaviour
{
    public Texture[] frames;        // normal animation frames
    public Texture[] brokenFrames;  // frames to use when task is complete
    public float fps = 8f;

    public bool ObjectBroken = false;

    private Renderer rend;

    void Start()
    {
        rend = GetComponentInChildren<Renderer>();
    }

    void Update()
    {
        if (rend == null)
            return;

        // choose the active frame set
        Texture[] activeFrames = ObjectBroken ? brokenFrames : frames;

        if (activeFrames == null || activeFrames.Length == 0)
            return;

        int frame = Mathf.FloorToInt(Time.time * fps) % activeFrames.Length;
        rend.material.mainTexture = activeFrames[frame];
    }

    public static implicit operator AnimationModels(bool v)
    {
        throw new NotImplementedException();
    }
}
