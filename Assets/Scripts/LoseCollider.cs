using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseCollider : MonoBehaviour {

	public LevelManager levelManager;

	void OnTriggerEnter2D (Collider2D collider)
	{
		levelManager.LoadLevel ("Game Over");
	}

	void OnCollisionEnter2D (Collision2D collision)
	{
		
	}
}
