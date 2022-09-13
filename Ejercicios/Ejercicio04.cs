using System.Collections.Generic;
using UnityEngine;

public class Ejercicio04 : MonoBehaviour
{
    public List<string> enemigos = new List<string>() { "Orco","Araña","Golem","Goblin"};

    string enemigo = "Araña";

	bool EncontrarEnemigo()
	{
		return enemigos.Contains(enemigo);
	}
}
