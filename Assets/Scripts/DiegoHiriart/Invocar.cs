using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Invocar : MonoBehaviour
{
    public GameObject objetivo;

    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnearObjeto", 2);//Llamar a la funcion una vez 2 segundos despues de esto
    }

    void SpawnearObjeto()
    {
        Instantiate(objetivo, new Vector3(0, 2, 0), Quaternion.identity);   
    }
}
