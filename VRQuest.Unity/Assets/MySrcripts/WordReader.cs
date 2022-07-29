using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class WordReader : MonoBehaviour
{ 

    // Update is called once per frame
    void Update()
    {
        string wordToApprove = "";
        string originalWord = "Cyprus";
        List<GameObject> boxList = GameObject.FindGameObjectsWithTag("Grabbed").ToList();
        boxList = boxList.OrderBy(cubeOnScene => cubeOnScene.transform.position.x).ToList();
        boxList = boxList.Where(cubeOnScene => cubeOnScene.GetComponent<Rigidbody>() == null).ToList();
        for(int i=0;i<boxList.Count;i++)
        {
            wordToApprove += boxList[i].GetComponent<CubeController>().key;
        }
        if(wordToApprove==originalWord)
        {
            Debug.Log("Win!");
            SceneManager.LoadScene("FinishScene");
        }
    }
}
