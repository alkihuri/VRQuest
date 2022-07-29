using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CubeController : MonoBehaviour
{
    public string key = "";
    public bool IsInbox;
    void Start()
    {
        IsInbox = false;
    }

    void Update()
    {
        for(int i=0;i<6;i++)
        {
            GetComponentsInChildren<Text>()[i].text = key;
        } 
    }
    public void SetRedColor()
    {
        GetComponent<Renderer>().material.color = Color.red;
    }
    public void SetWhiteColor()
    {
        GetComponent<Renderer>().material.color = Color.white;
    }
}
