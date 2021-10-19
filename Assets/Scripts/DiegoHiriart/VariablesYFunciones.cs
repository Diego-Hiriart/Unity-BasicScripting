using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VariablesYFunciones : MonoBehaviour
{
    int miEntero = 10;
    
    // Start is called before the first frame update
    void Start()
    {
        
        miEntero = MultiplicarPorDos(miEntero);
        Debug.Log(miEntero);
    }

    int MultiplicarPorDos(int numero)
    {
        int resultado;
        resultado = numero * 2;
        return resultado;
    }
}
