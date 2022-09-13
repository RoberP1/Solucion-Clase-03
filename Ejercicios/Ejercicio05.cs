using UnityEngine;

public class Ejercicio05 : MonoBehaviour
{
    string action = "Attack";

    void EjecutarAcción()
    {
        switch (action)
        {
            case "Heal":
                Debug.Log("Heal");
                break;
            case "Attack":
                Debug.Log("Make Damage");
                break;
            case "SpecialAttack":
                Debug.Log("I start to spin like a beyblade");
                break;
        }
    }
}


