//Diego Hiriart Leon
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerCamara : MonoBehaviour
{
    public GameObject jugador;//Referencia a la esfera
    private Vector3 diferencia;//Valor para mover la camara segun la posicion de la esfera
    // Start is called before the first frame update
    void Start()
    {
        diferencia = transform.position - jugador.transform.position;//Resta la pos de la camara menos la pos del player
    }

    // Update is called once per frame
    //Late update hace que se ejecute la funcion despues de que todos los proesos del frame se completen, por lo que no se mueve hasta que la esfera este
    //en su posicion final para ese frame
    void LateUpdate()
    {
        transform.position = jugador.transform.position + diferencia;//Se mueve la camara para que siga al player 
    }
}
