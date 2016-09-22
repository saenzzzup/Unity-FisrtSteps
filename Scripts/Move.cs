using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {
	//variables con velocidades 
	public float speed = 5.0f;
	public float turnSpeed = 20.0f;
	public float speedJump = 10.0f;
	//Objeto al cual vamos a llamar para disparar
	public GameObject bullet;  
	//El objecto que contenga este codigo
	Rigidbody rigidbodyCubo;
	//Sabes si esta o no tocando el piso
	bool piso = true;

	// Use this for initialization
	void Start () {
		//Conseguimos el Rigidbody del GameObject que contiene este coidgo
		rigidbodyCubo = GetComponent<Rigidbody> ();
		
	}
	
	// Update is called once per frame
	void Update () {
		//inputs para moverse
		float moveY = Input.GetAxis ("Horizontal");
		float moveX = Input.GetAxis ("Vertical");
		//Uno se mueve hacia adelante y atras
		transform.Translate(Vector3.forward * speed * moveX * Time.deltaTime);
		//Rota sobre el eje y con vetor unitario Vector3.up (0,1,0)
		transform.Rotate(Vector3.up, turnSpeed * moveY * Time.deltaTime);
		//Si apretamos J conseguimos crear un GameObject bala
		if (Input.GetKeyDown(KeyCode.J))
			Instantiate (bullet, transform.position, transform.rotation);
	
	}

	void FixedUpdate(){
		//Salto del objeto
		if (Input.GetKeyDown (KeyCode.Space) && piso) {
			piso = false;
			rigidbodyCubo.velocity = new Vector3 (rigidbodyCubo.velocity.x, speedJump, rigidbodyCubo.velocity.z);
		}
	}
	//saber si ya toco suelo para poder saltar nuevamente 
	void OnCollisionEnter(Collision collision){
		if (collision.gameObject.tag == "floor") {
			piso = true;
		}
	
	}

}
