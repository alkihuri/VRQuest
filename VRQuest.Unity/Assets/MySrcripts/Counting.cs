using UnityEngine;
using UnityEngine.SceneManagement;

public class Counting : MonoBehaviour
{
    [SerializeField] bool _doReset;
    [SerializeField] bool _doCount;
    private void Start()
    {
        if (_doReset)
        {
            StopWatch.stopWatch = 0;
        }
    }

    private void Update()
    {
        if (_doCount)
        {
            StopWatch.stopWatch+=Time.deltaTime;
            Debug.Log(StopWatch.stopWatch);
        }
    }
}
