using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableComponentes : MonoBehaviour
{
    private Light miLuz;
      
    // Start is called before the first frame update
    void Start()
    {
        miLuz = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.L))
        {
            miLuz.enabled = !miLuz.enabled;
        }
    }
}
