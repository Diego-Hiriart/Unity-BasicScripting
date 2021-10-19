using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{
    //Todo lo que hay aqui se puede reproducir con otros scripts
    public class Stuff//esta clase ya existe en inventario
    {
        public int bullets;
        public int grenades;
        public int rockets;

        public Stuff(int bul, int gre, int roc)//Constructor
        {
            bullets = bul;
            grenades = gre;
            rockets = roc;
        }
    }


    public Stuff myStuff = new Stuff(10, 7, 25);//Creacion de objeto
    //Movimiento
    public float speed;
    public float turnSpeed;
    //Disparar
    public Rigidbody bulletPrefab;
    public Transform firePosition;
    public float bulletSpeed;


    void Update()//Verifica si se debe mover o disparar
    {
        Movement();
        Shoot();
    }


    void Movement()//No se la necesita aqui, ya esta en otro script
    {
        float forwardMovement = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float turnMovement = Input.GetAxis("Horizontal") * turnSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * forwardMovement);
        transform.Rotate(Vector3.up * turnMovement);
    }


    void Shoot()//Tecnicamente no se la necesita aqui porque ya esta en otro script
    {
        if (Input.GetButtonDown("Fire1") && myStuff.bullets > 0)
        {
            Rigidbody bulletInstance = Instantiate(bulletPrefab, firePosition.position, firePosition.rotation) as Rigidbody;
            bulletInstance.AddForce(firePosition.forward * bulletSpeed);
            myStuff.bullets--;
        }
    }
}
