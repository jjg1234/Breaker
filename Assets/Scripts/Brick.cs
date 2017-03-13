using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour {

	public int m_MaxHits;
	private int m_TimesHits;

	// Use this for initialization
	void Start () {
		m_TimesHits = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		m_TimesHits++;

		if (m_TimesHits >= m_MaxHits)
		{
			Debug.Log("Destroyed !");
		}
	}
}
