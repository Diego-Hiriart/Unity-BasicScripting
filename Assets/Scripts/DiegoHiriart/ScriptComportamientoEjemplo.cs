using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptComportamientoEjemplo : MonoBehaviour
{   

    // Update is called once per frame
    void Update()
    {
        //Cambios de color al cubo segun la tecla presionada
        if (Input.GetKeyDown(KeyCode.R))
        {
            GetComponent<Renderer>().material.color = Color.red;
        }
        if (Input.GetKeyDown(KeyCode.G))
        {
            GetComponent<Renderer>().material.color = Color.green;
        }
        if (Input.GetKeyDown(KeyCode.B))
        {
            GetComponent<Renderer>().material.color = Color.blue;
        }
    }
}
