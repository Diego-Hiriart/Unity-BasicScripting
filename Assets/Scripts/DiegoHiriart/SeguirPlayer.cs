using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirPlayer : MonoBehaviour
{
    public float velocidadGiro = 15;
    public GameObject jugador;
    Vector3 diferenciaPos;//Para mover el arma, manteniendo su pos relativa al player

    // Start is called before the first frame update
    void Start()
    {
        diferenciaPos = this.transform.position - this.jugador.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = this.jugador.transform.position + diferenciaPos;
        //Rotacion (solo del arma sino es un caos)
        if (Input.GetKey(KeyCode.Q))
        {
            this.transform.Rotate( Vector3.forward, velocidadGiro * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.E))
        {
            this.transform.Rotate(Vector3.back, velocidadGiro * Time.deltaTime);
        }
    }
}
