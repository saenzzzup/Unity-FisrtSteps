using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	//Variable de tiempo donde guardadra sagundos pasados
	float time;
	//velocidad de la bala que se inicializa en 15
	public float speed = 15.0f;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		//Va guardando el tiempo en el que existe l GameObject
		time += 1.0F * Time.deltaTime;
		//Mueve el objeto en el espacio hacia ADELANTE 
		//Usa un vector unitario Vector3.forward := (0, 0, 1)
		transform.Translate(Vector3.forward * speed * Time.deltaTime);
		//Si el tiempo que paso es mayor o igual a 3 SEGUNDOS 
		//Destruye el objeto
		if (time >= 3)
			Destroy(this.gameObject);
	
	}
	//Si una caja de Trigger choca con el objeto se activa y toma al objeto con el cual choco
	// Este objeto es un Collider
	void OnTriggerEnter(Collider collision){
		//Selecciona el Collider y busca cual es su Tag
		if (collision.gameObject.tag == "enemy") {
			//Función de destruccion de gameObjects del escenario
			Destroy(this.gameObject);
		}
	
	}

}
