using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvokeRepeating : MonoBehaviour
{
    public GameObject objetivo;
    public int contador = 5;//Para no invocar por siempre

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnearObjeto", 5, 3);//En 5 segs, llamar a funcion cada 3 s

        //CancelInvoke("SpawnearObjeto");//Dejar de invocar la funcion;
    }

    // Update is called once per frame
    void SpawnearObjeto()
    {
        if (contador > 0)
        {
            Instantiate(objetivo, new Vector3(0, 3.5f, 0), Quaternion.identity);
            contador--;
        }
    }
}
