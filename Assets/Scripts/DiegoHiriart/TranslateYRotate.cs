using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TranslateYRotate : MonoBehaviour
{

    public float velocidadMover = 11f;
    public float velocidadGiro = 49f;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Alpha1))
            transform.Translate(Vector3.forward * velocidadMover * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha2))
            transform.Translate(-Vector3.forward * velocidadMover * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha3))
            transform.Rotate(Vector3.up, -velocidadGiro * Time.deltaTime);

        if (Input.GetKey(KeyCode.Alpha4))
            transform.Rotate(Vector3.up, velocidadGiro * Time.deltaTime);
    }
}
