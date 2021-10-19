using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetComponent : MonoBehaviour
{
    public GameObject otherGameObject;


    private OtroScript anotherScript;
    private OtroScriptMas yetAnotherScript;
    private BoxCollider boxCol;

    void Awake()
    {
        anotherScript = GetComponent<OtroScript>();
        yetAnotherScript = otherGameObject.GetComponent<OtroScriptMas>();
        boxCol = otherGameObject.GetComponent<BoxCollider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        boxCol.size = new Vector3(3, 3, 3);
        Debug.Log("El puntaje del jugador es " + anotherScript.playerScore);
        Debug.Log("El jugador ha muerto " + yetAnotherScript.numberOfPlayerDeaths + " veces");
    }
}
