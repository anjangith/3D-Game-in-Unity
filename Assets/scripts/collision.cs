using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class collision : MonoBehaviour {
	
	public float rSpeed=2f;
	public Text score;
	int score_count=0;
	enemy_instantiate InScr;
	public GameObject camera;
	bool isCollided=false;

	void Start () {
		
		InScr = GetComponent<enemy_instantiate> ();
	}
	
	void Update () {
		
		if (!isCollided) {
			//Level 1
			if (score_count > 3 && score_count < 10) {
				Debug.Log ("Score geater than 10");
				InScr.maxSpeed = 7f;

			//Level2
			} else if (score_count > 10 && score_count < 20) {
				InScr.maxSpeed = 10f;
			}
			//Level3
			else if (score_count > 20 && score_count < 30) {
				Debug.Log ("Score geater than 20");
				InScr.maxSpeed = 12f;
			}
			else if (score_count > 30 && score_count<45 ) {
				Debug.Log ("Score geater than 20");
				InScr.maxSpeed = 15f;
			}
			else if (score_count > 45 && score_count<60 ) {
				Debug.Log ("Score geater than 20");
				InScr.maxSpeed = 17f;
			}
			else if (score_count > 60 && score_count<100 ) {
				Debug.Log ("Score geater than 20");
				InScr.maxSpeed = 20f;
			}
		}

	}



	void OnCollisionEnter(Collision collision)
	{
		if (collision.collider.GetType() == typeof(MeshCollider))
		{	isCollided = true;
			InScr.maxSpeed = 0f;
			camera.GetComponent<CameraShake> ().enabled = true;
			StartCoroutine (Stop ());



		}

	}

	IEnumerator Stop()
	{

		yield return new WaitForSeconds(2);
		Time.timeScale = 0;

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.GetType() == typeof(BoxCollider))
		{
			switch(other.gameObject.tag){
			case "torus1":
				StartCoroutine (RotateObject (180, Vector3.right, 2, other.gameObject));
				score_count++;
				score.text = score_count.ToString();

			break;

			case "torus2":
				Debug.Log ("Collided with torus2");
				StartCoroutine(RotateObject(180, Vector3.right, 2,other.gameObject));
				score_count++;
				score.text = score_count.ToString();

			break;

			case "torus3":
				Debug.Log ("Collided with torus3");
				StartCoroutine(RotateObject(180, Vector3.right, 2,other.gameObject));
				score_count++;
				score.text = score_count.ToString();

			break;

			case "torus4":
				Debug.Log ("Collided with torus4");
				StartCoroutine(RotateObject(180, Vector3.right, 2,other.gameObject));
				score_count++;
				score.text = score_count.ToString();

			break;

			case "torus5":
				Debug.Log ("Collided with torus5");
				StartCoroutine(RotateObject(180, Vector3.right, 2,other.gameObject));
				score_count++;
				score.text = score_count.ToString();

			break;



		}   
	}
}



	IEnumerator RotateObject(float angle, Vector3 axis, float inTime,GameObject objectr)
	{
		// calculate rotation speed
		float rotationSpeed = (angle / inTime)*rSpeed;

	
			// save starting rotation position
			Quaternion startRotation = objectr.transform.rotation;

		float deltaAngle = objectr.transform.rotation.x;

			// rotate until reaching angle
			while (deltaAngle < angle)
			{
				deltaAngle += rotationSpeed * Time.deltaTime;
				deltaAngle = Mathf.Min(deltaAngle, angle);

				objectr.transform.rotation = startRotation * Quaternion.AngleAxis(deltaAngle, axis);

				yield return null;
			}

			// delay here
			yield return new WaitForSeconds(1);
		
	}
}
