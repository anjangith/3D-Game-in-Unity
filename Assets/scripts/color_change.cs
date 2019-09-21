using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class color_change : MonoBehaviour {

	float timeLeft;
	Color targetColor;

	void Update()
	{
		if (timeLeft <= Time.deltaTime)
		{
			// transition complete
			// assign the target color
			GetComponent<Renderer>().material.color = targetColor;

			// start a new transition
			targetColor = new Color(Random.value, Random.value, Random.value);
			timeLeft = 1.0f;
		}
		else
		{
			// transition in progress
			// calculate interpolated color
			GetComponent<Renderer>().material.color = Color.Lerp(GetComponent<Renderer>().material.color, targetColor, Time.deltaTime / timeLeft);

			// update the timer
			timeLeft -= Time.deltaTime;
		}
	}
}
