using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    public int inteligencia = 3;

    void Start()
    {
        this.Saludar(inteligencia);
    }

    private void Saludar(int inteligencia)
    {
        switch (inteligencia)
        {
            case 1:
                print("Ooga Booga");
                break;

            case 2:
                print("Quiuvo");
                break;

            case 3:
                print("Que más ve");
                break;

            case 4:
                print("Buen dia");
                break;

            case 5:
                print("Well hello there! Could I interest you in some pie?");
                break;

            default:
                print("Nivel de inteligencia inexistente");
                break;
        }
    }
}
