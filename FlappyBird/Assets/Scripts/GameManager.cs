using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

	public GameObject gameOverCanvas;

	private void Start() {
		Time.timeScale = 1;
		Screen.SetResolution(640, 1136, false); // iPhone 5 landscape, windowed
	}

	public void GameOver() {
		gameOverCanvas.SetActive(true);
		Time.timeScale = 0;
	}

	public void Replay() {
		SceneManager.LoadScene(1);
	}

}
