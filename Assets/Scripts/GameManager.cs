using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public static GameManager Instance;

    public GameObject gameOverCanvas;
    
    private void Awake() {
        if (Instance == null) Instance = this;
        Time.timeScale = 1;
    }

    public void GameOver() {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void RestartGame() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
