using UnityEngine;
using UnityEngine.UI;

public class GameManager: MonoBehaviour {
    [SerializeField] private Bird bird;
    [SerializeField] private Text scoreText;

    private int score = 0;

    public void AddScore() {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver() {
        bird.Die();
    }
}