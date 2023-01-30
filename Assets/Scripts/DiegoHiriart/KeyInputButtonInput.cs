using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class KeyInputButtonInput : MonoBehaviour
{
    //Este script no sirve completo porque no hay los sprites y el proyecto no es 2D

    public Image graphic;
    public Sprite standard;
    public Sprite downgfx;
    public Sprite upgfx;
    public Sprite heldgfx;
    public TextMeshProUGUI boolDisplay1;
    public TextMeshProUGUI boolDisplay2;
    public TextMeshProUGUI boolDisplay3;

    // Start is called before the first frame update
    void Start()
    {
        //Cambios de sprite comentados sino dan error
        //graphic.sprite = standard;

        bool up = Input.GetKeyUp(KeyCode.Space);
    }

    // Update is called once per frame
    void Update()
    {
        bool down = Input.GetKeyDown(KeyCode.W);
        bool held = Input.GetButton("Jump");
        bool up = Input.GetKeyUp(KeyCode.W);

        //Cambios de sprite comentados sino dan error
        if (down)
        {
            //graphic.sprite = downgfx;
        }
        else if (held)
        {
            //graphic.sprite = heldgfx;
        }
        else if (up)
        {
            //graphic.sprite = upgfx;
        }
        else
        {
            //graphic.sprite = standard;
        }

        boolDisplay1.text = "Button Down: " + down;
        boolDisplay2.text = "Button Held: " + held;
        boolDisplay3.text = "Button Up: " + up;
    }
}
