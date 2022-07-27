using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject cube; // здесь будет префаб кубика с буквой
    public string word; //  cлово для квеста
    // Start is called before the first frame update
    void Start()
    {
        word = "Cyprus"; /// присваиваем значение  
        for(int i=0;i<word.Length;i++) /// по количеству бук в слове...
        {
            MakeCube(word[i].ToString()); /// ...вызываем функцию создания куба  и передаем ей букву
        }
    }
    void MakeCube(string key) /// функция создания куба 
    {
        GameObject newCube = Instantiate(cube,new Vector3(0,0,0), new Quaternion(0,0,0,0)); /// устанавливем координаты для сброса буквы
        newCube.GetComponent<CubeController>().key = key;  /// присваиваем переменной key скрипта CubeController нужное значение буквы
    }
}
