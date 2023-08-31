using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {
    [SerializeField] private GameObject gameStartScreen;
    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private Bird bird;
    [SerializeField] private Text scoreText;

    private int score = 0;

    public void AddScore() {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameStart() {
        Time.timeScale = 1f;
        gameStartScreen.SetActive(false);
    }

    public void GameOver() {
        bird.Die();
        gameOverScreen.SetActive(true);
    }

    public void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}