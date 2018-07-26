using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	public Animator animator;
	private bool GameHasEnded = false;

	public Rotator rotator;
	public SpawnPin spawnpin;

	public void GameEnd()
	{
		if (GameHasEnded)
			return;
		
		rotator.enabled = false;
		spawnpin.enabled = false;
		GameHasEnded = true;
		animator.SetTrigger ("EndGame");
		Debug.Log ("GameEnd");
	}

	public void ResetLevel()
	{

		SceneManager.LoadScene (SceneManager.GetActiveScene ().buildIndex);
	}
}
