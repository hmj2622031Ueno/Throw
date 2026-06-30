using UnityEngine;

public class BombController : MonoBehaviour
{
    private GameManager gameManager;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Arena") || collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            if(collision.CompareTag("Enemy"))
            {
                gameManager.HitEnemy();
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gameManager = FindFirstObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
