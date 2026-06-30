using UnityEngine;
using UnityEngine.InputSystem;

public class BombThrow : MonoBehaviour
{
    [SerializeField] private GameObject bombPrefab;
    [SerializeField] private Transform throwPoint;
    [SerializeField] private float throwPower = 10f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Mouse.current.leftButton.wasPressedThisFrame) { Throw(); }
    }

    void Throw()
    {
        GameObject bomb = Instantiate(bombPrefab, throwPoint.position, throwPoint.rotation);
        Rigidbody bombRb = bomb.GetComponent<Rigidbody>();
        bombRb.AddForce(transform.forward * throwPower, ForceMode.Impulse);
    }
}
