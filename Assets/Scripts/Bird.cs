using UnityEngine;

public class Bird: MonoBehaviour {
    [SerializeField] private float jumpForce = 9f;
    [SerializeField] private float gravity = 32f;
    [SerializeField] private Rigidbody rigidBody;
    [SerializeField] private GameManager gameManager;

    private bool isAlive = true;

    private void Start() {
        Physics.gravity = Vector3.down * gravity;
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.Space) && isAlive) {
            rigidBody.velocity = Vector3.up * jumpForce;
        }
    }

    private void OnCollisionEnter(Collision collision) {
        gameManager.GameOver();
    }

    public void Die() {
        isAlive = false;
    }
}