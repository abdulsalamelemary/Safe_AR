using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FemaleManager : MonoBehaviour
{
    public Vector3 OriginalPos;
    public Quaternion OriginalRot;

    public void Play()
    {
        foreach(AudioSource s in GetComponentsInChildren<AudioSource>())
        {
            s.Play();
        }   
    }

    public void OnEnable()
    {
        OriginalPos = transform.localPosition;
        OriginalRot = transform.localRotation;
    }

    public void OnDisable()
    {
        transform.localPosition = OriginalPos;
        transform.localRotation = OriginalRot;
    }

} // Female Manager
