using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class EnemyHealth : MonoBehaviour
{
	public int startingHealth = 20;
	public int currentHealth;
	public Slider healthSlider;

	void Awake()
	{
		currentHealth = startingHealth;
	}

	public void TakeDamage(int amount)
	{
		currentHealth -= amount;
		healthSlider.value = currentHealth;
		if (currentHealth <= 0)
		{
			Destroy(gameObject);
			SceneManager.LoadScene("LevelComplete");
		}
	}
}
