using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    public List<string> enemigos = new List<string>() { "Orco","Ara�a","Golem","Goblin"};

    string enemigo = "Ara�a";

	bool EncontrarEnemigo()
	{
		return enemigos.Contains(enemigo);
	}
}
