using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public static int score;
	static ScoreManager instance = null;

	Text text;


    void Awake()
    {
		if (instance != null)
		{
			Destroy(gameObject);
		}
		else
		{
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}

		text = GetComponent<Text>();

	}

    void Update()
    {

		text.text = "Score: " + score;
    }
}
