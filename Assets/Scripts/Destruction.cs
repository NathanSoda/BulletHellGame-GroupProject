using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destruction : MonoBehaviour
{
	public int scoreValue = -15;
	public int enemyDamage = 1;
	GameObject Player;
	PlayerHealth playerHealth;

	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag("Player");
		playerHealth = Player.GetComponent<PlayerHealth>();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Player)
		{
			playerHealth.TakeDamage(enemyDamage);
			ScoreManager.score += scoreValue;
			Destroy(gameObject);
		}
	}
}
