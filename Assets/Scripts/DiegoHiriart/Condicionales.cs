using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Condicionales : MonoBehaviour
{
    float temperaturaCafe = 51f;
    float limiteCaliente = 45f;
    float limiteFrio = 22f;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PruebaTemp();
        }
            
        temperaturaCafe -= Time.deltaTime * 5f;
    }

    void PruebaTemp()
    {
        //Temp del cafe encima de limite calor
        if (temperaturaCafe > limiteCaliente)
        {
            //Hacer esto
            print("El cafe esta muy caliente");
        }
        //Cafe debajo del limite inferior
        else if (temperaturaCafe < limiteFrio)
        {
            //Imprimir: 
            print("El cafe esta muy frio");
        }
        //Si esta entre los rangos
        else
        {
            //Se imprime:
            print("La temperatura del cafe es adecuada");
        }
    }
}
