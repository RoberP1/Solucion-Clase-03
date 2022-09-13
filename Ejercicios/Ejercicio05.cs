using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string action = "Attack";

    void EjecutarAcción()
    {
        switch (action)
        {
            case "Heal":
                Debug.Log("Me curé");
                break;
            case "Attack":
                Debug.Log("Hago daño");
                break;
            case "SpecialAttack":
                Debug.Log("Empiezo a girar como trompo");
                break;
        }
    }
}


