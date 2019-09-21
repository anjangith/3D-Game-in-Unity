using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class swipe_control : MonoBehaviour {
		
	private Vector3 fp;   //First touch position
	private Vector3 lp;   //Last touch position
	public float speed = 1f;
	public float dragDistance;
	private Rigidbody rigidBody;
	public float offset=1f;
	// Use this for initialization
	void Start () {


	}
	
	// Update is called once per frame

		void FixedUpdate()
		{
			if (Input.touchCount == 1) // user is touching the screen with a single touch
			{
				Touch touch = Input.GetTouch(0); // get the touch
				if (touch.phase == TouchPhase.Began) //check for the first touch
				{
					fp = touch.position;
					lp = touch.position;
				}
				else if (touch.phase == TouchPhase.Moved) // update the last position based on where they moved
				{
					lp = touch.position;
					if (Mathf.Abs(lp.x - fp.x) > dragDistance || Mathf.Abs(lp.y - fp.y) > dragDistance)
					{//It's a drag
					//check if the drag is vertical or horizontal
					if (Mathf.Abs(lp.x - fp.x) > Mathf.Abs(lp.y - fp.y))
					{   //If the horizontal movement is greater than the vertical movement...
						if ((lp.x > fp.x))  //If the movement was to the right)
						{   //Right swipe
							Vector3 currentPos= new Vector3(transform.position.x,transform.position.y,transform.position.z);
							Vector3 newPos = new Vector3 (transform.position.x + offset, transform.position.y, transform.position.z);
							transform.position=  Vector3.Lerp(currentPos,newPos,Time.deltaTime*speed);

							

						}
						else
						{   //Left swipe
							//rigidBody.AddRelativeForce (-Vector3.right*speed);
							//transform.Translate (-Vector3.right);
							//transform.position=new Vector3(-Time.deltaTime*(float)speed,transform.position.y,transform.position.z);


							Vector3 currentPos= new Vector3(transform.position.x,transform.position.y,transform.position.z);
							Vector3 newPos = new Vector3 (transform.position.x - offset, transform.position.y, transform.position.z);
							transform.position=  Vector3.Lerp(currentPos,newPos,Time.deltaTime*speed);					}
					}
					else
					{   //the vertical movement is greater than the horizontal movement
						if (lp.y > fp.y)  //If the movement was up
						{   //Up swipe
							Debug.Log("Up Swipe");
						}
						else
						{   //Down swipe
							Debug.Log("Down Swipe");
						}
					}
				}
				else
				{   //It's a tap as the drag distance is less than 20% of the screen height
					Debug.Log("Tap");
				}
				}
				else if (touch.phase == TouchPhase.Ended) //check if the finger is removed from the screen
				{
					lp = touch.position;  //last touch position. Ommitted if you use list

					//Check if drag distance is greater than 20% of the screen height
					
				}
			}
	}
}
	
	