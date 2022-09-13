using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    public List<string> enemigos = new List<string>() { "Orco","Mosquito","Golem","Goblin"};

    string enemigo = "Mosquito";

	bool EncontrarEnemigo()
	{
		return enemigos.Contains(enemigo);
	}
}
