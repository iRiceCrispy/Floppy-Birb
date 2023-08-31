using UnityEngine;

public class CheckPoint: MonoBehaviour {
    private GameManager gameManager;

    private void Start() {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    private void OnTriggerEnter(Collider other) {
        gameManager.AddScore();
    }
}