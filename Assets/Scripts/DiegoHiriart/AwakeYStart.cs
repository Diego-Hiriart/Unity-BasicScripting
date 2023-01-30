using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwakeYStart : MonoBehaviour
{
    //Ninguna de las dos duncioens se puede llamar dos veces para un mismo objeto
    
    void Awake()
    {
        //Se llama primero, util apra referencias entre scripts e inicializacion
        //Se llama incluso con el componente de script deshabilitado
        Debug.Log("Se llama a awake");
    }

    // Start is called before the first frame update
    void Start()
    {
        //Solo se llama si el componente esta habiltado, despues de awake y antes del primer update       
        Debug.Log("LLamada a start");
    }
}
