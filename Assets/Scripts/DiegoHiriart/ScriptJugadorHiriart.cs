using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Inventario;//Pasa usar la clase Stuff

public class ScriptJugadorHiriart : MonoBehaviour
{
    private Stuff inventario;
    public float velocidadMov = 10;
    public float velocidadSalto = 15;
    public GameObject prefabBala;//Game object para poder activar un prefab deshabilitado
    public GameObject prefabCohete;
    public GameObject prefabGranada;
    public Transform barrilArma;
    public Transform manoLanza;
    public float velocBala = 100;
    public float velocCohete = 3000;
    public float velocGranada = 170;

    // Start is called before the first frame update
    void Start()
    {
        this.inventario = new Stuff(27, 10 ,15);//Llenar inventario      
    }

    void Update()
    {
        Disparar();
    }

    // Para aplicar fisica (saltos)
    void FixedUpdate()
    {
        //Traslacion
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Rigidbody>().AddForce(-1 * velocidadMov* Time.deltaTime, 0, 0);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Rigidbody>().AddForce(1 * velocidadMov * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey(KeyCode.S))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, -1 * velocidadMov * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.W))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 0, 1 * velocidadMov * Time.deltaTime);
        }        

        //Saltos
        if (Input.GetKey(KeyCode.Space))
        {
            this.GetComponent<Rigidbody>().AddForce(0, 1 * velocidadSalto * Time.deltaTime, 0);
        }
    }

    //Controlar disparos
    private void Disparar()
    {
        if (Input.GetButtonDown("Fire1") && inventario.GetBalas() > 0)
        {
            //Crear una bala y ponerla adelante del player
            GameObject bulletInstance = Instantiate(prefabBala, barrilArma.position, barrilArma.rotation) as GameObject;
            bulletInstance.SetActive(true);//Habilitar la bala
            bulletInstance.GetComponent<Rigidbody>().AddForce(barrilArma.up * velocBala);
            inventario.bullets--;          
        }
        if (Input.GetButtonDown("Fire2"))
        {
            if (inventario.GetCohetes() > 0)
            {
                GameObject rocketInstance;
                rocketInstance = Instantiate(prefabCohete, barrilArma.position, barrilArma.rotation) as GameObject;
                rocketInstance.SetActive(true);//Habilitar objeto               
                rocketInstance.GetComponent<Rigidbody>().AddForce(barrilArma.up * velocCohete);
                inventario.rockets--;               
            }
        }
        if (Input.GetKeyUp(KeyCode.G))
        {
            if (inventario.GetGranadas() > 0)
            {
                GameObject rocketInstance;
                rocketInstance = Instantiate(prefabGranada, manoLanza.position + new Vector3(-1.5f, 1f, 1f), manoLanza.rotation) as GameObject;
                rocketInstance.SetActive(true);//Habilitar objeto
                rocketInstance.transform.Rotate(90, 0, 0);//Girar a direccion adecuada
                rocketInstance.GetComponent<Rigidbody>().AddForce((manoLanza.forward + manoLanza.up) * velocGranada);//Lanzar granadas para adelante y arriba
                inventario.grenades--;               
            }
        }
    }

    //Para usar el inventario en UIAmmo
    public Stuff GetInventario()
    {
        return this.inventario;
    }
}
