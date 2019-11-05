using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDestruction : MonoBehaviour
{
	public int playerDamage = 1;
	GameObject Player;
	EnemyHealth eHealth;

	void Awake()
	{
		Player = GameObject.FindGameObjectWithTag("Boss");
		eHealth = Player.GetComponent<EnemyHealth>();
	}


	void OnTriggerEnter(Collider other)
	{
		if (other.gameObject == Player)
		{
			eHealth.TakeDamage(playerDamage);
			Destroy(gameObject);
		}
	}
}
