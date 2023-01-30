using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiposDatos : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Tipo valor
        Vector3 posicionActual = transform.position;//Vector3 es un struct, que es tipo valor
        posicionActual = new Vector3(3, 0, 0);//Se cambia el valor, solo la copia de la posicion

        //Tipo referencia
        Transform tran = transform;//Transform es una clase
        tran.position = new Vector3(1.26f, 2f, -3f);//Se cambia tran, que al ser una referencia, cambia el transform
    }

}
