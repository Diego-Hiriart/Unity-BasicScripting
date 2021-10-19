using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateYFixedUpdate : MonoBehaviour
{
    private float timerUpdate;
    private float timerFixedUpdate;

    private bool impreso1 = false, impreso2 = false;//Se imprime demsasiado

    /* Ctrl+Shitf+M abre un wizard que crea funciones de MonoBwehaviour,
     * es util para ver las funciones disponibles y aniadirlas
     */

    void FixedUpdate()
    {
        //Se le llama en cada paso de fisica
        //Se llama en intevalos constantes, es ideal para aplicar fisica para objectos
        if (!impreso1)//Se imprime demsasiado
        {
            Debug.Log("Tiempo de FixedUpdate: " + Time.deltaTime);//El tiempo es fijo, se notara en la impresion
            impreso1 = true;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        //Se lo llama cada frame, se usa para mover objetos nofisicos, timers simples, leer inputs
        //No se llama en intervalos fijos al ser llamado en cada frame
        if (!impreso2)//Se imprime demsasiado
        {
            Debug.Log("Tiempo de Update: " + Time.deltaTime);//El tiempo se vera que es variable
            impreso2 = true;
        }      

    }
}
