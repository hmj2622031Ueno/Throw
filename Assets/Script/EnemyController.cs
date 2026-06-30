using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform player;
    [SerializeField] private Animator animator;
    [SerializeField] private GameObject bombPrefab;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Bomb") || collision.CompareTag("Player") || collision.CompareTag("Arena"))
        {
            Destroy(gameObject);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, 180, 0);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.y = 0;

        transform.position += direction.normalized * speed * Time.deltaTime;

        if(direction != Vector3.zero)
        {
            animator.SetBool("isWalk", true);
        }
        else
        {
            animator.SetBool("isWalk", false);
        }

        if(transform.position.z <= player.position.z)
        {
            Destroy(gameObject);
            SceneManager.LoadScene("ResultScene");
        }
    }
}
