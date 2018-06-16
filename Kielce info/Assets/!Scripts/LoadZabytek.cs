using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadZabytek : MonoBehaviour {

    public static ZabyktiObcjetc[] objects;
    public ZabyktiObcjetc[] obcjetcsS;

    public GameObject buttonO;

    public GameObject field;

    private void Start()
    {
        objects = obcjetcsS;
        for (int i = 0; i < objects.Length; i++)
        {
            GameObject buttonC = Instantiate(buttonO, field.transform.position, Quaternion.identity, field.transform);
            buttonC.GetComponent<ButtonListControler>().info = objects[i];
        }
    }
}
