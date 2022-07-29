using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;

public class WordReader : MonoBehaviour
{
    public string originalWord;
    public string nextScene;

    // Update is called once per frame
    void Update()
    {
        string wordToApprove = "";
        List<GameObject> boxList = GameObject.FindGameObjectsWithTag("Grabbed").ToList();
        boxList = boxList.OrderBy(cubeOnScene => cubeOnScene.transform.position.x).ToList();
        boxList = boxList.Where(cubeOnScene => cubeOnScene.GetComponent<CubeController>().IsInbox).ToList();
        for (int i = 0; i < boxList.Count; i++)
        {
            wordToApprove += boxList[i].GetComponent<CubeController>().key;
        }
        if (wordToApprove == originalWord)
        {
            Debug.Log("Win!");
            SceneManager.LoadScene(nextScene);
        }
    }
}
