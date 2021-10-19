using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SintaxisBasica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Un comentario se inicia con dos slashes
        /*
        * Un comentario de multiples lineas tiene esta forma
        */

        Debug.Log(transform.position.x); 

        if(transform.position.y <= 5f)
        {
            Debug.Log("Voy a golpear el piso");
        }
    }

}
