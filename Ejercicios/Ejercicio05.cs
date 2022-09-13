using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    /*---- Mejora el Switch ----*/

    //Dato: como podriamos hacer para no usar tantos "if"?

    string Acción = "Attack";
    int Habilidad = 1;

    void EjecutarAcción()
    {
        switch (Habilidad)
        {
            case 1:
                if(Acción == "Heal")
                    Debug.Log("Me curé");
                break;
            case 2:
                if (Acción == "Attack")
                    Debug.Log("Hago daño");
                break;
            case 3:
                if (Acción == "Special Attack")
                    Debug.Log("Empiezo a girar como trompo");
                break;
         
        }
    }
}
}
