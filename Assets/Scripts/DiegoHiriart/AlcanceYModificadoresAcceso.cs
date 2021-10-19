using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlcanceYModificadoresAcceso : MonoBehaviour
{
    public int unaPublica = 5;

    private int unaPrivada = 0;
    private int otraPrivada = 5;

    private OtraClase miOtraClase;

    bool impreso = true;//Se imprimia demasiado

    private void Start()
    {
        unaPublica = 29;
        miOtraClase = new OtraClase();
        miOtraClase.MaquinaFrutas(unaPublica, miOtraClase.manzanas);
    }

    void Ejemplo(int esferos, int crayones)
    {
        int respuesta;
        respuesta = esferos * crayones * unaPublica;
        Debug.Log(respuesta);
    }

    // Update is called once per frame
    void Update()
    {      
        if (impreso)//Se imprimia demasiado
        {
            Debug.Log("La variable publica tiene el valor: " + unaPublica);
            impreso = false;
        }       
    }
}
