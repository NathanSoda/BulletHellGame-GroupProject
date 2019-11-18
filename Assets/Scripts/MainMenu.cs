using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
	public GameObject Image;
	public void LoadScene(int level)
	{
		Image.SetActive(true);
		SceneManager.LoadScene(level);
	}
}
