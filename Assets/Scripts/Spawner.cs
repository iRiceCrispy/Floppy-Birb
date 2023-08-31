using UnityEngine;

public class Spawner: MonoBehaviour {
    [SerializeField] private GameObject obstacles;
    [SerializeField] private float heightOffSet = 3.5f;
    [SerializeField] private float spawnRate = 2f;

    private float timer = 0f;

    private void Start() {
        Spawn();
    }

    private void Update() {
        timer += Time.deltaTime;

        if (timer >= spawnRate) {
            Spawn();
            timer = 0f;
        }
    }

    private void Spawn() {
        float minHeight = transform.position.y - heightOffSet;
        float maxHeight = transform.position.y + heightOffSet;
        float randomHeight = Random.Range(minHeight, maxHeight);
        Vector3 spawnPosition = new Vector3(transform.position.x, randomHeight, transform.position.z);

        Instantiate(obstacles, spawnPosition, transform.rotation);
    }
}