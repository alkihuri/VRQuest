using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Graber : MonoBehaviour
{
    RaycastHit objectOnHitLine;
    // Update is called once per frame
    void Update()
    { 
        if(Physics.Raycast(transform.position,transform.forward,out objectOnHitLine))
        {
            if(objectOnHitLine.transform.gameObject.tag == "Grab")
            {
                objectOnHitLine.transform.Rotate(0, 1, 1);
            }
        }
    }
}
