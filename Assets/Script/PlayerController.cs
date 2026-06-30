using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 10.0f;
    [SerializeField] private Animator animator;
    [SerializeField] private Transform cameraTransform;

    private void OnTriggerEnter(Collider collision)
    {
        if(collision.CompareTag("Enemy"))
        {
            Destroy(gameObject);
            SceneManager.LoadScene("ResultScene");
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 move = Vector3.zero;

        //if(Keyboard.current.wKey.isPressed) { move += Vector3.forward; }
        //if(Keyboard.current.sKey.isPressed) { move += Vector3.back; }
        if(Keyboard.current.aKey.isPressed) { move += Vector3.left; }
        if(Keyboard.current.dKey.isPressed) { move += Vector3.right; }

        move.Normalize();
        transform.position += move * speed * Time.deltaTime;

        Vector3 forward = cameraTransform.forward;
        forward.y = 0;

        if(forward != Vector3.zero)
        {
            transform.forward = forward;
        }

        if(Mouse.current.leftButton.wasPressedThisFrame)
        {
            animator.SetTrigger("isThrow");
        }

        if(move != Vector3.zero)
        {
            transform.forward = move; 
            animator.SetBool("isRun", true);
            animator.SetBool("isSideRun", true);
        }
        else { animator.SetBool("isRun", false); }
    }
}