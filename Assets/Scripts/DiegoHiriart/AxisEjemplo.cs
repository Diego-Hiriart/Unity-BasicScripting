using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AxisEjemplo : MonoBehaviour
{
    public float range;
    public TextMeshProUGUI textOutput;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float xPos = h * range;

        transform.position = new Vector3(xPos, 2f, transform.position.z);
        textOutput.text = "Value Returned: " + h.ToString("F2");
    }
}
