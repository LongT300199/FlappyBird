using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public GameObject gameOverCanvas;

	private void Start() {
		Time.timeScale = 1;
	}

	public void GameOver() {
		gameOverCanvas.SetActive(true);
		Time.timeScale = 0;
	}

}
