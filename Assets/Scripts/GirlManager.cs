using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class GirlManager : MonoBehaviour
{
    public UnityEvent OnDoorOpen, OnDoorClosed;

    public Vector3 OriginalPos;
    public Quaternion OriginalRot;

    private void Awake()
    {
        OriginalPos = transform.position;
        OriginalRot = transform.rotation;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void TriggerOpenDoor()
    {
        OnDoorOpen.Invoke();
    }

    void TriggerCloseDoor()
    {
        OnDoorClosed.Invoke();
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
}
