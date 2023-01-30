using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Disparar : MonoBehaviour
{
    //Atributos
    public GameObject bulletPrefab;//Game object para poer activar un prefab deshabilitado
    public Transform firePosition;
    public float bulletSpeed;


    private Inventario inventory;


    void Awake()//Coje el inventario para saber si hay cosas que disparar
    {
        inventory = GetComponent<Inventario>();
    }


    void Update()
    {
        Shoot();
    }


    void Shoot()//Dispara y reduce la balas
    {
        if (Input.GetButtonDown("Fire1") && inventory.myStuff.GetBalas() > 0)
        {
            //Crear una bala y ponerla adelante del player
            GameObject bulletInstance = Instantiate(bulletPrefab, firePosition.position + new Vector3(0,0,0.75f), firePosition.rotation) as GameObject;
            bulletInstance.SetActive(true);//Habilitar la bala
            bulletInstance.transform.Rotate(90,0,0);//Rotar la bala a la orientacion correcta
            bulletInstance.GetComponent<Rigidbody>().AddForce(firePosition.forward * bulletSpeed);
            inventory.myStuff.bullets--;

            Debug.Log("Balas: " + inventory.myStuff.GetBalas());
        }
    }
}
