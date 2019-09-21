using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class instantiate : MonoBehaviour {
	public GameObject player;
	public GameObject myPrefab;
	public GameObject rightWall;
	public GameObject leftWall;
	BoxCollider m_Collider;
	float distanceY;

	float offset=10f;
	float multiplier=1f;
	// Use this for initialization
	void Start () {

		m_Collider = myPrefab.GetComponent<BoxCollider> ();
				
	}
	
	// Update is called once per frame
	void Update () {
		
		float posY = m_Collider.bounds.max.y;
		if(player.transform.position.y>offset){
			
			distanceY = posY*multiplier;
			//GameObject obj1=Instantiate(myPrefab, new Vector3(6,distanceY, 0), Quaternion.identity);
			//GameObject obj2=Instantiate(myPrefab, new Vector3(-6,distanceY, 0), Quaternion.identity);
			rightWall.transform.position=new Vector3(9,distanceY,0);
			leftWall.transform.position = new Vector3 (-9, distanceY, 0);
			offset = rightWall.transform.position.y ;
			multiplier++;




	}
}
}
