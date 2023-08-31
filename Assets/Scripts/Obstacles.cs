using UnityEngine;

public class Obstacles: MonoBehaviour {
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float deadZone = -15f;

    private void Update() {
        transform.position = transform.position + (Vector3.left * moveSpeed * Time.deltaTime);

        if (transform.position.x <= deadZone) {
            Destroy(gameObject);
        }
    }
}