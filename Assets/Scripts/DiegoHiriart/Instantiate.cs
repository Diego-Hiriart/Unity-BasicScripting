using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public GameObject rocketPrefab;
    public Transform barrelEnd;
    private Inventario inventario;

    private void Start()
    {
        inventario = GetComponent<Inventario>();
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            if (inventario.myStuff.GetCohetes() >0)
            {
                GameObject rocketInstance;
                rocketInstance = Instantiate(rocketPrefab, barrelEnd.position, barrelEnd.rotation) as GameObject;
                rocketInstance.SetActive(true);//Habilitar objeto
                rocketInstance.transform.Rotate(90, 0, 0);//Girar a direccion adecuada
                rocketInstance.GetComponent<Rigidbody>().AddForce(barrelEnd.forward * 3000);
                inventario.myStuff.rockets--;

                Debug.Log("Cohetes: " + inventario.myStuff.GetCohetes());
            }            
        }
    }
}
