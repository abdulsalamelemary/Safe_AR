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
            transform.LookAt(objectToLookAt.transform , transform.parent.up);
            //transform.rotation = new Quaternion(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y, 0, 0);
        }
    }
}
