using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivacionObjects : MonoBehaviour
{
    public GameObject objeto;
    // Start is called before the first frame update
    void Start()
    {       

        Debug.Log("Estado active self: "+objeto.activeSelf);
        objeto.SetActive(false);
        Debug.Log("Estado activo en jerarquia: " + objeto.activeInHierarchy);
    }

}
