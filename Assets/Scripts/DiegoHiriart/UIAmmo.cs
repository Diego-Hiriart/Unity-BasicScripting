using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIAmmo : MonoBehaviour
{
    public TextMeshProUGUI balas;
    public TextMeshProUGUI cohetes;
    public TextMeshProUGUI granadas;
    private ScriptJugadorHiriart inventario;

    //Inicializar inventario
    private void Start()
    {
        this.inventario = GetComponent<ScriptJugadorHiriart>();//Asignar inventario del otro script
    }

    //Actualizar UI de municion
    void Update()
    {
        balas.text = "Balas: " + inventario.GetInventario().GetBalas();
        cohetes.text = "Cohetes: " + inventario.GetInventario().GetCohetes();
        granadas.text = "Granadas: " + inventario.GetInventario().GetGranadas();
    }
}
