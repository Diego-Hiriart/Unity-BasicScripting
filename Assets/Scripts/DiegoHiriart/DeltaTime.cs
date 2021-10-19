using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeltaTime : MonoBehaviour
{
    public float velocidad = 8f;
    public float conteo = 3.0f;

    // Update is called once per frame
    void Update()
    {
        conteo -= Time.deltaTime;
        if(conteo <= 0.0f)
        {
            GetComponent<Light>().enabled = true;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += new Vector3(velocidad * Time.deltaTime, 0.0f, 0.0f);
        }
    }
}
