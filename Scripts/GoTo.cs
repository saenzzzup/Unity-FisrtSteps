using UnityEngine;
using System.Collections;

public class GoTo : MonoBehaviour {
	//velocidad 
	public float speed = 0.5f;
	//Hacia donde va a ir nuestro objeto
	public Transform target;
	

	// Use this for initialization
	void Start () {
		//Conseguimos el GameObject que va a saguir 
		target = GameObject.Find ("Character").transform;
	}
	
	// Update is called once per frame
	void Update () {
		//Medimos distancia entre este objeto y nuestro objetivo 
		float dist = Vector3.Distance(target.position, transform.position);
		//Gira hacia donde este el objetivo
		transform.LookAt(target);
		//Mietras la distancia sea mayor a 3 Unidades, va a moverse hacia el objetivo
		if(dist > 3.0f)
			transform.position = Vector3.MoveTowards (transform.position,target.position,speed * Time.deltaTime);

	}
}
