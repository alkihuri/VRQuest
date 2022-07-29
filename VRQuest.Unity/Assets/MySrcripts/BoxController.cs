using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="Grabbed")
        {
            other.transform.SetParent(transform);
            other.gameObject.GetComponent<CubeController>().IsInbox = true;
            Destroy(other.gameObject.GetComponent<Rigidbody>());
            other.transform.position = transform.position + new Vector3(0, 1, 0);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
