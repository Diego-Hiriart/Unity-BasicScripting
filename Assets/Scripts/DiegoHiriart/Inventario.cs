using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventario : MonoBehaviour
{
    public class Stuff//Clase
    {
        public int bullets;//Atributos
        public int grenades;
        public int rockets;
        public float fuel;

        public Stuff(int bul, int gre, int roc)//Constructores
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }

        public Stuff(int bul, float fu)
        {
            bullets = bul;
            fuel = fu;
        }

        // Constructor por defecto
        public Stuff()
        {
            bullets = 1;
            grenades = 1;
            rockets = 1;
        }

        public int GetBalas()
        {
            return this.bullets;
        }

        public int GetGranadas()
        {
            return this.grenades;
        }

        public int GetCohetes()
        {
            return this.rockets;
        }
    }


    // Creacion de objetos tipo Stuff
    public Stuff myStuff = new Stuff(25, 5, 10);

    public Stuff myOtherStuff = new Stuff(25, 1.5f);

    void Start()
    {
        Debug.Log(myStuff.bullets);
        Debug.Log(myStuff.grenades);
        Debug.Log(myStuff.rockets);
    }

}
