using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_instantiate : MonoBehaviour {

	public GameObject[] prefab;
	private Rigidbody rigidBody;
	public float maxSpeed = 3f;



	// Use this for initialization
	void Start () {
		
		rigidBody = GetComponent<Rigidbody> ();

	}

	void FixedUpdate(){

		Vector3 newVel = rigidBody.velocity;
		newVel.y = maxSpeed;
		rigidBody.velocity = newVel;

	}
	
	// Update is called once per frame
	void Update () {



		if(transform.position.y>prefab[0].transform.position.y+10){
			float position = Random.Range (-3.5f, 3.5f);
			float random = Random.Range (10.0f, 15.0f);
			prefab [0].transform.position = new Vector3 (position, prefab [4].transform.position.y + random, prefab [4].transform.position.z);
	
		}
		if(transform.position.y>prefab[1].transform.position.y+10){
			float position = Random.Range (-3.5f, 3.5f);
			float random = Random.Range (10.0f, 15.0f);
			prefab [1].transform.position = new Vector3 (position, prefab [0].transform.position.y + random, prefab [0].transform.position.z);
	
		}
		if(transform.position.y>prefab[2].transform.position.y+10){
			float position = Random.Range (-3.5f, 3.5f);
			float random = Random.Range (10.0f, 15.0f);
			prefab [2].transform.position = new Vector3 (position ,prefab [1].transform.position.y + random, prefab [1].transform.position.z);

		}

		if(transform.position.y>prefab[3].transform.position.y+10){
			float position = Random.Range (-3.5f, 3.5f);
			float random = Random.Range (10.0f, 15.0f);
			prefab [3].transform.position = new Vector3 (position, prefab [2].transform.position.y + random, prefab [2].transform.position.z);

		}

		if(transform.position.y>prefab[4].transform.position.y+10){
			float position = Random.Range (-3.5f, 3.5f);
			float random = Random.Range (10.0f, 15.0f);
			prefab [4].transform.position = new Vector3 (position, prefab [3].transform.position.y + random, prefab [3].transform.position.z);
	}
}
}
