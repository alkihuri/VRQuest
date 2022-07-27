using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grabber : MonoBehaviour
{ 
    RaycastHit objectOnHitLine; 
    // Update is called once per frame
    void Update()
    {
        if (Physics.Raycast(transform.position, transform.forward, out objectOnHitLine))
        {
            if (objectOnHitLine.transform.gameObject.tag == "Grabbed")
            {
                objectOnHitLine.transform.Rotate(0, 0.1f, 0);

                if (Input.GetButtonDown("Fire1"))     //если  нажата клавиша Fire1
                {
                    objectOnHitLine.transform.SetParent(transform);    /// прикрепить к объекту со скриптом 
                    objectOnHitLine.transform.position = transform.forward * 3; /// закрепить позицию схваченого объекта
                    Destroy(objectOnHitLine.transform.gameObject.GetComponent<Rigidbody>()); /// отключаем Rigidbody/Гравитацию 
                }
                if (Input.GetButtonUp("Fire1")) //если    клавиша Fire1 отпущена 
                {
                    objectOnHitLine.transform.SetParent(null); /// открепляем объект
                    objectOnHitLine.transform.gameObject.AddComponent<Rigidbody>(); ///  добавялем RigidBody/Гравитацию 
                    objectOnHitLine.transform.gameObject.GetComponent<Rigidbody>().AddForce(Camera.main.transform.forward * 450);
                }
            }
        }
    }
}


/// 