using UnityEngine;
using System.Collections;

public class Enemy : MonoBehaviour {
	//Vida del Enemigo, es publica y se puede editar en los componentes. 
	//Se inicializa en 3
	public int life = 3;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Si la vida es menor o igual a 0 
		//Este objecto se destruye 
		if(life<=0)
			//Función de destruccion de gameObjects del escenario
			Destroy(this.gameObject);
	
	}
	//Si una caja de Trigger choca con el objeto se activa y toma al objeto con el cual choco
	// Este objeto es un Collider
	void OnTriggerEnter(Collider collision){
		//Selecciona el Collider y busca cual es su Tag
		if (collision.gameObject.tag == "bullet") {
			//Al ser el Tag que buscamos le quita uno en vida
			life--;
		}
	
	}
}
