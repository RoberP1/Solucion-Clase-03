using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string action = "Attack";
    int ability = 1;

    enum abilities{
        Heal = 1,
        Attack = 2,
        SpecialAttack = 3
    }

    void EjecutarAcci�n()
    {
        if ((abilities)ability.ToString() != action) return;
        switch (ability)
        {
            case 1:
                Debug.Log("Me cur�");
                break;
            case 2:
                Debug.Log("Hago da�o");
                break;
            case 3:
                Debug.Log("Empiezo a girar como trompo");
                break;
        }
    }
}


