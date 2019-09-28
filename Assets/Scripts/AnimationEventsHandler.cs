using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class AnimationEventsHandler : MonoBehaviour
{
    public UnityEvent[] Events;


    public void TriggerEvent(int EventNumber)
    {
        Events[EventNumber].Invoke();
    }

}
