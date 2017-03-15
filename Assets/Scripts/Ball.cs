using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

	enum BallStates { Idle,Launched}

	private Paddle m_Paddle;
	private BallStates m_BallState = BallStates.Idle;
	Vector3 paddleToBallVector;
	// Use this for initialization
	void Start () {
		m_Paddle = GameObject.FindObjectOfType<Paddle>();

		paddleToBallVector = this.transform.position - m_Paddle.transform.position;
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		if (m_BallState == BallStates.Launched)
		{
			this.GetComponent<AudioSource>().Play();
		}
		
	}

	// Update is called once per frame
	void Update () {

		switch (m_BallState)
		{
			case BallStates.Idle:
				this.transform.position = m_Paddle.transform.position + paddleToBallVector;

				if (Input.GetMouseButton(0))
				{
					Rigidbody2D myRigidBody = this.GetComponent<Rigidbody2D>();
					myRigidBody.velocity = new Vector2(2.0f,10.0f);
					m_BallState = BallStates.Launched;
				}
				break;
			case BallStates.Launched:
				break;
			default:
				break;
		}

		

		
		
	}
}
