using UnityEngine;

public class Ejercicio02 : MonoBehaviour
{
    int fuerza = 100;
    int agilidad = 50;

    int fuerzaNecesaria = -1;
    int agilidadNecesaria = 20;

    private void EjecutarAtaqueEspecial()
    {
        float multiplicadorFuerza = 2 / 5;
        float multiplicadorAgilidad = 1 / 2;

        bool fuerzaSuficiente = fuerza * multiplicadorFuerza < fuerzaNecesaria;

        bool agilidadSuficiente = agilidad * multiplicadorAgilidad < agilidadNecesaria;

        if (fuerzaSuficiente && agilidadSuficiente)
        {
            Debug.Log("Ataque especial ejecutado");
        }
    }
}
