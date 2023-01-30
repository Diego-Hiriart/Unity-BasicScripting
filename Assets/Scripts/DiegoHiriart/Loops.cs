using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loops : MonoBehaviour
{
    int tazas = 4;
    int enemigos = 3;
    // Start is called before the first frame update
    void Start()
    {
        //Bucle while
        while(tazas > 0)
        {
            Debug.Log("Se lavo una taza");
            tazas--;
        }

        bool continuar = false;

        //Bucle do while
        do
        {
            print("Hola mundo");
        } while (continuar == true);

        //Bucle for
        for(int i = 0; i < enemigos; i++)
        {
            Debug.Log("Spawn de enemigo numero: " + i);
        }

        //Bucle foreach
        string[] strings = new string[3];

        strings[0] = "Primer string";
        strings[1] = "Segundo string";
        strings[2] = "Tercer string";

        foreach(string item in strings)
        {
            print(item);
        }
    }

}
