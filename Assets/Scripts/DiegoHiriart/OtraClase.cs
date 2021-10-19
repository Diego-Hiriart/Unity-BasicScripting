using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OtraClase
{
    public int manzanas;
    public int bananas;


    private int grapadora;
    private int cintaScotch;

    public void MaquinaFrutas(int a, int b)
    {
        int respuesta;
        respuesta = a + b;
        Debug.Log("Total de frutas: " + respuesta);
    }


    private void Oficina(int a, int b)
    {
        int respuesta;
        respuesta = a + b;
        Debug.Log("Total de suministros de oficina: " + respuesta);
    }
}
