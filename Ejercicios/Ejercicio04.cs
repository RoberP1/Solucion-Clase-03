using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    /*---- Busca otra alternativa ----*/

    /*Dato:Queremos saber si existe el nombre de un enemigo dentro de una lista.
      Podriamos mejorarlo usando algun método de Linq.
    */

    public List<string> enemigos = new List<string>() { "Orco","Araña","Golem","Goblin"};
    string enemigo = "Araña";



    string EncontrandoEnemigo()
    {
        for (int i = 0; i < enemigos.Length; i++)
        {
            if (enemigos[i].Equals("Araña"))
            {
                return "Se Encontro Araña";
            }
        }

        return "No se encontró";


    }
}
