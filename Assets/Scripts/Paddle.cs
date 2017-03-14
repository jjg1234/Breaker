using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float min = 0.5f;
		float max = 15.5f;

		float MousePosition = Input.mousePosition.x / Screen.width * 16;
		this.transform.position = new Vector3(Mathf.Clamp(MousePosition,min,max), 0.5f, 0.0f);


			

	}
}
