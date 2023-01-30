using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento : MonoBehaviour
{
    public float speed;//Atributos
    public float turnSpeed;


    void Update()
    {
        Movement();
    }


    void Movement()//Controla un personaje con ejes
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float movLateral = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        //Rotacion con q y e
        float rotacion = 0;
        if (Input.GetKey(KeyCode.Q))
        {
            rotacion = -1 * turnSpeed * Time.deltaTime;
        }else if (Input.GetKey(KeyCode.E))
        {
            rotacion = 1 * turnSpeed * Time.deltaTime;
        }

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Translate(Vector3.right * movLateral);
        transform.Rotate(Vector3.up * rotacion);
    }
}
