using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruccionProyectil : MonoBehaviour
{
    public float tiempo = 10;
    
    void Start()
    {
        Destroy(gameObject, tiempo);
    }
}
