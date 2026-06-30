using UnityEngine;

public class EnemyGenerator : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    //[SerializeField] int enemyCount = 5;
    [SerializeField] float spawnInterval = 2f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        InvokeRepeating(nameof(SpawnEnemy), 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomX = Random.Range(-20f, 25f);

        Vector3 spawnPos = new Vector3(randomX, transform.position.y + 1.5f, transform.position.z);

        Instantiate(enemyPrefab, spawnPos, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
