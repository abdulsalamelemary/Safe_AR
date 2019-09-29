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
            CancelInvoke("HideTarget");
            ObjectToShowIfTargetVisible.SetActive(true);
        }
        else
        {
            Invoke("HideTarget" , 1);           
        }
    }

    void HideTarget()
    {
        ObjectToShowIfTargetVisible.SetActive(false);
    }

} // end class Checker
