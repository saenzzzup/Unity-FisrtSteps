using UnityEngine;
using System.Collections;

public class EnemyCreator : MonoBehaviour {
	//GameObject que sera nuestro Enemigo, un GameObject que se va a estar creando
	public GameObject enemy;    
	//Tiempo de segundos de cuanto se va a tardar en aparecer otro Objeto
	public float spawnTime = 5.0f; 
	//minimos y maximos para hacer el Spwan de los enemigos 
	public int maxX, minX, maxZ, minZ;


	// Use this for initialization
	void Start () {
		//invoca una Funcion cada cierto tiempo 
		// Nombre de la Funcion, y tiempo en que se va a ejecutar 
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}
	//Funcion que se invoca 
	void Spawn()
	{
		//Se crea un Random con el rango minimo y maximo que se puso (ENTEROS)
		int spawnPointX = Random.Range(maxX, minX);
		int spawnPointZ = Random.Range(maxZ, minZ);
		//crea el vector donde se va a crear (posicion)
		Vector3 spawnPosition = new Vector3(spawnPointX, 0, spawnPointZ);
		//Se crea el objeto en la posicion con una rotacion 
		Instantiate (enemy, spawnPosition, Quaternion.identity);
	}
}
