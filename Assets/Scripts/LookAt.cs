using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour
{

    public GameObject objectToLookAt;

    // Update is called once per frame
    void Update()
    {
        if (objectToLookAt != null)
        {
            transform.LookAt(objectToLookAt.transform);
        }
    }
}
