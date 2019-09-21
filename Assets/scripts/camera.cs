using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour {

	Color color1;
	Color color2;
	public float duration = 3.0F;
	public Camera cam;

	void Start()
	{
		cam = GetComponent<Camera>();
		cam.clearFlags = CameraClearFlags.SolidColor;
		color1 = new Color (Random.value, Random.value, Random.value);
		color2 = new Color (Random.value, Random.value, Random.value);

	}

	void Update()
	{
		float t = Mathf.PingPong(Time.time, duration) / duration;
		cam.backgroundColor = Color.Lerp(color1, color2, t);
	}

}
