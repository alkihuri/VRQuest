using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
     public void GameStart()
    {
        SceneManager.LoadScene("Quest");
    }
    public void StartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
