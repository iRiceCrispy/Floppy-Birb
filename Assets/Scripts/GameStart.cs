using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStart: MonoBehaviour {
    [SerializeField] private GameManager gameManager;

    private void Start() {
        Time.timeScale = 0f;
    }
    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) {
            gameManager.GameStart();
        }
    }
}
