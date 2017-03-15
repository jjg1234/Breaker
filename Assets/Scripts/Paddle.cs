using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	public bool m_Autoplay;
	// Use this for initialization
	void Start () {
		ChangeColorState(1.0f);
	}
	
	// Update is called once per frame
	void Update ()
	{
		float min = 0.5f;
		float max = 15.5f;

		if (!m_Autoplay)
		{
			MoveWithMouse(min, max);
		}
		else
		{
			MoveWithBall(min, max);
		}
	}

	public static void ChangeColorState(float _state)
	{

		Color Gradiant = new Color( (Color.red * _state).r, (Color.green * (1-_state)).g , 0);
		GameObject.FindObjectOfType<Paddle>().GetComponent<SpriteRenderer>().color = Gradiant;
		
	}


	private void MoveWithMouse(float min, float max)
	{
		float MousePosition = Input.mousePosition.x / Screen.width * 16;
		this.transform.position = new Vector3(Mathf.Clamp(MousePosition, min, max), 0.5f, 0.0f);
	}

	private void MoveWithBall(float min, float max)
	{
		this.transform.position = new Vector3(Mathf.Clamp(GameObject.FindObjectOfType<Ball>().transform.position.x,min,max),this.transform.position.y);
	}
}
