using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DualAxis : MonoBehaviour
{
    public TextMeshProUGUI horizontalValueDisplayText;
    public TextMeshProUGUI verticalValueDisplayText;
    public float hRange;
    public float vRange;

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        float xPos = h * hRange;
        float yPos = v * vRange;

        transform.position = new Vector3(xPos, transform.position.y, yPos);
        horizontalValueDisplayText.text = h.ToString("F2");
        verticalValueDisplayText.text = v.ToString("F2");
    }
}
