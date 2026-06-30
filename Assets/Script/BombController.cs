using UnityEngine;

public class BombController : MonoBehaviour
{
    [SerializeField] GameObject manager;
    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Arena") || collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            if(collision.CompareTag("Enemy"))
            {
                manager.GetComponent<GameManager>().HitEnemy();
            }
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
