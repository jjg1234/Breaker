using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	private LevelManager m_LevelManager;

	private void OnCollisionEnter2D(Collision2D collision)
	{
		Debug.Log("Collide");
	}


	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log("Trigger");
		m_LevelManager = GameObject.FindObjectOfType<LevelManager>();
		m_LevelManager.LoadLevel("Lose");
	}
}
