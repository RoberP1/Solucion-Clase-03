using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string action = "Attack";

    void EjecutarAcci�n()
    {
        switch (action)
        {
            case "Heal":
                Debug.Log("Me cur�");
                break;
            case "Attack":
                Debug.Log("Hago da�o");
                break;
            case "SpecialAttack":
                Debug.Log("Empiezo a girar como trompo");
                break;
        }
    }
}


