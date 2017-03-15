using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Brick : MonoBehaviour
{

	private int m_TimesHits;
	public Sprite[] m_HitSprites;
	public static int s_BreakableBrickCount = 0;
	private bool m_IsBreakable;
	// Use this for initialization
	void Start()
	{
		m_TimesHits = 0;
		m_IsBreakable = CompareTag("Breakable");
		if (m_IsBreakable)
		{
			s_BreakableBrickCount++;
		}

	}

	// Update is called once per frame
	void Update()
	{

	}

	private void OnCollisionEnter2D(Collision2D collision)
	{
		HandleHit();
	}

	private void HandleHit()
	{
		if (m_IsBreakable)
		{
			m_TimesHits++;

			int m_MaxHits = m_HitSprites.Length + 1;

			if (m_TimesHits >= m_MaxHits)
			{
				Destroy(gameObject);
				s_BreakableBrickCount--;
				GameObject.FindObjectOfType<LevelManager>().BrickDestroyed();
			}
			else
			{
				if (m_HitSprites.Length >= m_TimesHits)
				{
					if (m_HitSprites[m_TimesHits - 1] != null)
					{
						gameObject.GetComponent<SpriteRenderer>().sprite = m_HitSprites[m_TimesHits - 1];
					}
					else
					{
						throw new ArgumentNullException("Brick", "Brick sprite is null");
					}
				}
				else
				{
					throw new IndexOutOfRangeException("Trying to acces sprite " + (m_TimesHits - 1) + " and there is only " + (m_HitSprites.Length - 1) + " sprites.");
				}

			}
		}
	}


}
