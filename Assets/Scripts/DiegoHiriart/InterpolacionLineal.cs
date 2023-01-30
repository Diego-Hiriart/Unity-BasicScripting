using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterpolacionLineal : MonoBehaviour
{    
    public Light luz;

    // Start is called before the first frame update
    void Start()
    {
        //Interpolar el 50% entre 3 y 5, osea 4
        float result = Mathf.Lerp(3f, 5f, 0.5f);//de 3 a 5, el 50%

        //Vector entre los dos vectores, estaa un 75% del inicio y 25 del final
        Vector3 inicio = new Vector3(1f, 2f, 3f);
        Vector3 final = new Vector3(5f, 6f, 7f);

        //El resultado sera (4,5,6), 4 al 75 de 1 y 5, 5 al 75% de 2 y 6, 6 al 75% de 3 y 7
        Vector3 resultado = Vector3.Lerp(inicio, final, 0.75f);
    }

    // Update is called once per frame
    void Update()
    {
        //Lerp de luces, puede usarse para intensidad o para RGB (vector)
        luz.intensity = Mathf.Lerp(luz.intensity, 15f, 0.3f * Time.deltaTime);//La intensidad cambiara hasta llegar a 15, de 0.5 en 0.5 y cada vez mas lento
    }
}
