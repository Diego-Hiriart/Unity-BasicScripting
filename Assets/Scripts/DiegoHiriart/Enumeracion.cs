using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enumeracion : MonoBehaviour
{
    enum Direccion : int {Norte, Este, Sur, Oeste};//Constantes, son tipo int
    
    // Start is called before the first frame update
    void Start()
    {
        Direccion miDireccion;

        miDireccion = Direccion.Norte;

        Debug.Log(RevertirDireccion(miDireccion).ToString());
    }

    // Update is called once per frame
    Direccion RevertirDireccion(Direccion dir)
    {
        if (dir == Direccion.Norte)
            dir = Direccion.Sur;
        else if (dir == Direccion.Sur)
            dir = Direccion.Norte;
        else if (dir == Direccion.Este)
            dir = Direccion.Oeste;
        else if (dir == Direccion.Oeste)
            dir = Direccion.Este;

        return dir;
    }
}
