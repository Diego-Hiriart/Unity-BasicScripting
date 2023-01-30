using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    public GameObject otro;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.M))//Destruir otro objeto
        {
            Destroy(otro, 3f);//Con 3 segundos de delay
        }

        if (Input.GetKey(KeyCode.N))//Destruir un componente de este objeto
        {
            Destroy(GetComponent<MeshRenderer>(), 4f);
        }

        if (Input.GetKey(KeyCode.O))//Destruirse a si mismo
        {
            Destroy(gameObject, 5f);
        }
    }
}
