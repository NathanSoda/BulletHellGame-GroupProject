using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class PlayerHealth : MonoBehaviour
{
	public int startingHealth = 8;
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
			SceneManager.LoadScene("Gameover");
			ScoreManager.score = 15;
		}
	}
}
