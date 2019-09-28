using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public bool bActiveByDefault;
    [Space]
    public Transform Target;
    public GameObject ObjectToShowIfTargetVisible;

    private void Awake()
    {
        checkActive();
    }

    private void OnDisable()
    {
        checkActive();
    }
    void checkActive()
    {
        if (bActiveByDefault)
        {
            ObjectToShowIfTargetVisible.gameObject.SetActive(true);
            gameObject.SetActive(true);
        }
        else
        {
            ObjectToShowIfTargetVisible.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }


    // Update is called once per frame
    void Update()
    {
        Debug.DrawLine(transform.position, Target.position);
        if (!Physics.Linecast(transform.position, Target.position))
        {
            ObjectToShowIfTargetVisible.SetActive(true);
        }
        else
        {
            ObjectToShowIfTargetVisible.SetActive(false);
        }
    }

} // end class Checker
